using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnightFrank.Tests.Regression.Model;


namespace KnightFrank.Blog.Tests.Regression
{
    class SeleniumHelper
    {
        public static class constant
        {
            public const string blogWatermark = "Search the blog";
            public const string propertyURL = "http://www.knightfrank.co.uk/blog/category/property";
            public const string newsURL = "http://www.knightfrank.co.uk/blog/category/news";
            public const string lifestyleURL = "http://www.knightfrank.co.uk/blog/category/lifestyle";
            public const string intelligenceURL = "http://www.knightfrank.co.uk/blog/category/intelligence";
            public const string intelligenceColor = "rgba(216, 194, 0, 1)";
            public const string lifestyleColor = "rgba(255, 147, 70, 1)";
            public const string newsColor = "rgba(187, 22, 123, 1)";
            public const string propertyColor = "rgba(0, 204, 193, 1)";
        }

        private static IWebDriver _webdriver;
        public static IWebDriver WebDriver
        {
            get
            {
                if (_webdriver == null)
                {
                    _webdriver = new ChromeDriver();
                }
                return _webdriver;
            }
        }

        public static IWebDriver SetUpDriver()
        {
            WebDriver.Url = System.Configuration.ConfigurationManager.AppSettings["betaKnightFrankBlog"];

            WebDriver.Manage().Window.Maximize();
            return WebDriver;
        }

        public static IWebDriver SetUpHomepage()
        {
            WebDriver.Url = System.Configuration.ConfigurationManager.AppSettings["KnightFrankHome"];

            WebDriver.Manage().Window.Maximize();
            return WebDriver;
        }

        public static IWebDriver SetUpAdminDriver()
        {
            SeleniumHelper.WebDriver.Url = System.Configuration.ConfigurationManager.AppSettings["betaKnightFrankBlogAdmin"];

            WebDriver.Manage().Window.Maximize();
            return WebDriver;
        }

        public static IWebDriver BlogHomeMobile()
        {
            WebDriver.Url = System.Configuration.ConfigurationManager.AppSettings["betaKnightFrankBlog"];

            WebDriverWait waitforContent = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
            waitforContent.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div/div[1]/div")));

            WebDriver.Manage().Window.Size = new System.Drawing.Size(375, 667);
            return WebDriver;
        }

        public static IWebDriver TabletHomeMobile()
        {
            WebDriver.Url = System.Configuration.ConfigurationManager.AppSettings["betaKnightFrankBlog"];

            WebDriverWait waitforContent = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
            waitforContent.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div/div[1]/div")));

            WebDriver.Manage().Window.Size = new System.Drawing.Size(768, 1024);
            return WebDriver;
        }

        public static IWebDriver LargeTabletHomeMobile()
        {
            WebDriver.Url = System.Configuration.ConfigurationManager.AppSettings["betaKnightFrankBlog"];

            WebDriverWait waitforContent = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
            waitforContent.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div/div[1]/div")));

            WebDriver.Manage().Window.Size = new System.Drawing.Size(1366, 1024);
            return WebDriver;
        }
        public static IWebDriver SetUpContactUsAtoZ()
        {
            WebDriver.Url = "http://beta.knightfrank.co.uk/contact/offices/atoz/United_Kingdom";

            WebDriver.Manage().Window.Maximize();
            return WebDriver;
        }

        public static void ValidateBlog()
        {
            var pageTitle = WebDriver.Title;
            Assert.Equal("Knight Frank Blog", pageTitle);

            var heroLinks = WebDriver.FindElement(By.XPath("//div/div[2]"));
            Assert.True(heroLinks.Displayed);

            WebDriverWait waitForPosts = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(20));
            waitForPosts.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div/div[1]/results/div/div[24]/a/div")));

            //first thumbnail 
            var thumbnailOne = WebDriver.FindElement(By.XPath("//div/div[1]/results/div/div[1]"));
            Assert.True(thumbnailOne.Displayed);

            //Third row Thumbnail
            var thumbnailTwo = WebDriver.FindElement(By.XPath("//div/div[1]/results/div/div[11]"));
            Assert.True(thumbnailTwo.Displayed);

            //Last thumbnail 
            var thumbnailThree = WebDriver.FindElement(By.XPath("//div/div[1]/results/div/div[24]"));
            Assert.True(thumbnailThree.Displayed);
        }

        public static void OpenTheBlogSearch()
        {
            var openSearch = WebDriver.FindElement(By.XPath("/html/body/div[2]/blog/featured-posts/section/div/blog-nav/social-nav/div[1]/a[4]/i"));
            openSearch.Click();

            var waterMark = WebDriver.FindElement(By.ClassName("watermark")).Text;
            Assert.Equal(constant.blogWatermark, waterMark);
        }

        public static void SearchTextNumbers()
        {
            var searchTextThree = WebDriver.FindElement(By.Id("SearchTerm2"));
            searchTextThree.SendKeys("Private View 2017");
        }

        public static void PressTheReturnKey()
        {
            var keyboardReturn = WebDriver.FindElement(By.Id("SearchTerm2"));
            keyboardReturn.SendKeys(Keys.Return);
        }

        public static void ValidateResult()
        {
            var searchTerm = WebDriver.FindElement(By.Id("SearchTerm2")).Text;
            var searchResults = WebDriver.FindElement(By.XPath("//div/div[1]/results/div[1]")).Text;

            WebDriverWait waitForMessage = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
            waitForMessage.Until(ExpectedConditions.ElementIsVisible(By.ClassName("resultsBar")));

            Assert.Contains(searchTerm, searchResults);
        }

        public static void AllCategoriesTab()
        {
            var allCategories = WebDriver.FindElement(By.XPath("/html/body/div[2]/blog/featured-posts/section/div/blog-nav/nav/ul/li[5]/a")).GetCssValue("background-color");
            Assert.Equal("rgba(208, 16, 58, 1)", allCategories);
        }

        public static void PressPropertyCategory()
        {
            WebDriverWait waitForTopNav = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
            waitForTopNav.Until(ExpectedConditions.ElementIsVisible(By.ClassName("navigation")));

            var propertyCat = WebDriver.FindElement(By.XPath("/html/body/div[2]/blog/featured-posts/section/div/blog-nav/nav/ul/li[4]/a"));
            propertyCat.Click();
        }

        public static void PropertyCategory()
        {
            var propertyCatColor = WebDriver.FindElement(By.XPath("/html/body/div[2]/blog/featured-posts/section/div/blog-nav/nav/ul/li[4]/a")).GetCssValue("background-color");
            Assert.Equal("rgba(0, 204, 193, 1)", propertyCatColor);

            Assert.Equal(WebDriver.Url, constant.propertyURL);
        }

        public static void pressNewsCategory()
        {
            WebDriverWait waitForTopNav = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
            waitForTopNav.Until(ExpectedConditions.ElementIsVisible(By.ClassName("navigation")));

            var newsCategory = WebDriver.FindElement(By.XPath("/html/body/div[2]/blog/featured-posts/section/div/blog-nav/nav/ul/li[3]/a"));
            newsCategory.Click();
        }

        public static void NewsCategory()
        {
            var newsCatColor = WebDriver.FindElement(By.XPath("/html/body/div[2]/blog/featured-posts/section/div/blog-nav/nav/ul/li[3]/a")).GetCssValue("background-color");
            Assert.Equal("rgba(187, 22, 123, 1)", newsCatColor);

            Assert.Equal(WebDriver.Url, constant.newsURL);
        }

        public static void pressLifestyleCategory()
        {
            WebDriverWait waitForTopNav = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
            waitForTopNav.Until(ExpectedConditions.ElementIsVisible(By.ClassName("navigation")));

            var lifestyleCategory = WebDriver.FindElement(By.XPath("/html/body/div[2]/blog/featured-posts/section/div/blog-nav/nav/ul/li[2]/a"));
            lifestyleCategory.Click();
        }

        public static void LifestyleCategory()
        {
            var lifestyleCatColor = WebDriver.FindElement(By.XPath("/html/body/div[2]/blog/featured-posts/section/div/blog-nav/nav/ul/li[2]/a")).GetCssValue("background-color");
            Assert.Equal("rgba(255, 147, 70, 1)", lifestyleCatColor);

            Assert.Equal(WebDriver.Url, constant.lifestyleURL);
        }

        public static void PressIntelligenceCategory()
        {
            WebDriverWait waitForTopNav = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
            waitForTopNav.Until(ExpectedConditions.ElementIsVisible(By.ClassName("navigation")));

            var lifestyleCategory = WebDriver.FindElement(By.XPath("/html/body/div[2]/blog/featured-posts/section/div/blog-nav/nav/ul/li[1]/a"));
            lifestyleCategory.Click();
        }

        public static void IntelligenceCategory()
        {
            var intelligenceCatColor = WebDriver.FindElement(By.XPath("/html/body/div[2]/blog/featured-posts/section/div/blog-nav/nav/ul/li[1]/a")).GetCssValue("background-color");
            Assert.Equal("rgba(216, 194, 0, 1)", intelligenceCatColor);

            Assert.Equal(WebDriver.Url, constant.intelligenceURL);
        }

        public static void PressHamburgerMenu()
        {
            WebDriverWait waitForHam = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
            waitForHam.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/section/div[1]/div/div[2]/a/i")));

            var hamburger = WebDriver.FindElement(By.XPath("/html/body/div[1]/section/div[1]/div/div[2]/a/i")).GetCssValue("font-size");
            Assert.Equal("42px", hamburger);

            var pressHamburger = WebDriver.FindElement(By.XPath("/html/body/div[1]/section/div[1]/div/div[2]/a/i"));
            pressHamburger.Click();
        }

        public static void IntelligenceHamburger()
        {
            WebDriverWait waitForNav = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            waitForNav.Until(ExpectedConditions.ElementIsVisible(By.ClassName("navmenu")));

            var hamburgerMenu = WebDriver.FindElement(By.ClassName("navmenu")).Text;
            Assert.Contains("Intelligence", hamburgerMenu);
            Assert.Contains("Lifestyle", hamburgerMenu);
            Assert.Contains("News", hamburgerMenu);
            Assert.Contains("Property", hamburgerMenu);
            Assert.Contains("All Categories", hamburgerMenu);

            var hamburgerIntelligence = WebDriver.FindElement(By.XPath("//div[1]/div/h4/a"));
            hamburgerIntelligence.Click();
        }

        public static void LifestyleHamburger()
        {
            WebDriverWait waitForNav = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            waitForNav.Until(ExpectedConditions.ElementIsVisible(By.ClassName("navmenu")));

            var hamburgerMenu = WebDriver.FindElement(By.ClassName("navmenu")).Text;
            Assert.Contains("Intelligence", hamburgerMenu);
            Assert.Contains("Lifestyle", hamburgerMenu);
            Assert.Contains("News", hamburgerMenu);
            Assert.Contains("Property", hamburgerMenu);
            Assert.Contains("All Categories", hamburgerMenu);

            var hamburgerLifestyle = WebDriver.FindElement(By.XPath("//div[2]/div/h4/a"));
            hamburgerLifestyle.Click();
        }

        public static void NewsHamburger()
        {
            WebDriverWait waitForNav = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            waitForNav.Until(ExpectedConditions.ElementIsVisible(By.ClassName("navmenu")));

            var hamburgerMenu = WebDriver.FindElement(By.ClassName("navmenu")).Text;
            Assert.Contains("Intelligence", hamburgerMenu);
            Assert.Contains("Lifestyle", hamburgerMenu);
            Assert.Contains("News", hamburgerMenu);
            Assert.Contains("Property", hamburgerMenu);
            Assert.Contains("All Categories", hamburgerMenu);

            var hamburgerNews = WebDriver.FindElement(By.XPath("//div[3]/div/h4/a"));
            hamburgerNews.Click();
        }

        public static void PropertyHamburger()
        {
            WebDriverWait waitForNav = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            waitForNav.Until(ExpectedConditions.ElementIsVisible(By.ClassName("navmenu")));

            var hamburgerMenu = WebDriver.FindElement(By.ClassName("navmenu")).Text;
            Assert.Contains("Intelligence", hamburgerMenu);
            Assert.Contains("Lifestyle", hamburgerMenu);
            Assert.Contains("News", hamburgerMenu);
            Assert.Contains("Property", hamburgerMenu);
            Assert.Contains("All Categories", hamburgerMenu);

            var hamburgerProperty = WebDriver.FindElement(By.XPath("//div[4]/div/h4/a"));
            hamburgerProperty.Click();
        }

        public static void CloseHamburger()
        {
            var hamburgerMenu = WebDriver.FindElement(By.ClassName("navmenu")).Text;
            Assert.Contains("Intelligence", hamburgerMenu);
            Assert.Contains("Lifestyle", hamburgerMenu);
            Assert.Contains("News", hamburgerMenu);
            Assert.Contains("Property", hamburgerMenu);
            Assert.Contains("All Categories", hamburgerMenu);

            var pressHamburger = WebDriver.FindElement(By.XPath("/html/body/div[1]/section/div[1]/div/div[2]/a/i"));
            pressHamburger.Click();
        }

        public static void IntelligenceSubCat()
        {
            WebDriverWait waitFroDropdownOne = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
            waitFroDropdownOne.Until(ExpectedConditions.ElementIsVisible(By.Id("dropdownMenu1")));

            var intelligenceSubDropdown = WebDriver.FindElement(By.Id("dropdownMenu1")).GetCssValue("background-color");
            Assert.Equal(intelligenceSubDropdown, constant.intelligenceColor);
        }

        public static void LifestyleSubCat()
        {
            WebDriverWait waitFroDropdownOne = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
            waitFroDropdownOne.Until(ExpectedConditions.ElementIsVisible(By.Id("dropdownMenu1")));

            var lifestyleSubDropdown = WebDriver.FindElement(By.Id("dropdownMenu1")).GetCssValue("background-color");
            Assert.Equal(lifestyleSubDropdown, constant.lifestyleColor);
        }

        public static void NewsSubCat()
        {
            WebDriverWait waitFroDropdownOne = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
            waitFroDropdownOne.Until(ExpectedConditions.ElementIsVisible(By.Id("dropdownMenu1")));

            var lifestyleSubDropdown = WebDriver.FindElement(By.Id("dropdownMenu1")).GetCssValue("background-color");
            Assert.Equal(lifestyleSubDropdown, constant.newsColor);
        }

        public static void PropertySubCat()
        {
            WebDriverWait waitFroDropdownOne = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
            waitFroDropdownOne.Until(ExpectedConditions.ElementIsVisible(By.Id("dropdownMenu1")));

            var propertySubDropdown = WebDriver.FindElement(By.Id("dropdownMenu1")).GetCssValue("background-color");
            Assert.Equal(propertySubDropdown, constant.propertyColor);
        }

        public static void IntelligencePost()
        {
            WebDriverWait waitForThumb = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
            waitForThumb.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div/div[1]/results/div/div[1]/a/div/div[3]")));

            var intelligencePost = WebDriver.FindElement(By.XPath("//div/div[1]/results/div/div[1]/a/div/div[3]")).GetCssValue("border-color");
            Assert.Equal("rgb(216, 194, 0)", intelligencePost);
        }
        
        public static void LifestylePost()
        {
            WebDriverWait waitForThumb = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
            waitForThumb.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div/div[1]/results/div/div[1]/a/div/div[3]")));

            var lifestylePost = WebDriver.FindElement(By.XPath("//div/div[1]/results/div/div[1]/a/div/div[3]")).GetCssValue("border-color");
            Assert.Equal("rgb(255, 147, 70)", lifestylePost);
        }

        public static void NewsPost()
        {
            WebDriverWait waitForThumb = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
            waitForThumb.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div/div[1]/results/div/div[1]/a/div/div[3]")));

            var newsPost = WebDriver.FindElement(By.XPath("//div/div[1]/results/div/div[1]/a/div/div[3]")).GetCssValue("border-color");
            Assert.Equal("rgb(187, 22, 123)", newsPost);
        }

        public static void PropertyPost()
        {
            WebDriverWait waitForThumb = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
            waitForThumb.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div/div[1]/results/div/div[1]/a/div/div[3]")));

            var propertyPost = WebDriver.FindElement(By.XPath("//div/div[1]/results/div/div[1]/a/div/div[3]")).GetCssValue("border-color");
            Assert.Equal("rgb(0, 204, 193)", propertyPost);
        }

        public static void ResTabClick()
        {
            var clickResTab = SeleniumHelper.WebDriver.FindElement(By.Id("cpMain_ucc1_ctl00_liTabResidential"));
            clickResTab.Click();
        }

        public static void comTabClick()
        {
            var commercialTab = SeleniumHelper.WebDriver.FindElement(By.Id("cpMain_ucc1_ctl00_liTabCommercial"));
            commercialTab.Click();
        }

        public static void HouseFilter()
        {
            var openDropDown = SeleniumHelper.WebDriver.FindElement(By.Id("simpleselect_cpMain_ucc1_ctl00_ddlResidentialBuyPropertyTypes"));
            openDropDown.Click();

            WebDriverWait waitForOption = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForOption.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#simpleselect_cpMain_ucc1_ctl00_ddlResidentialBuyPropertyTypes > div.options > div:nth-child(2)")));

            var selectHouse = SeleniumHelper.WebDriver.FindElement(By.CssSelector("#simpleselect_cpMain_ucc1_ctl00_ddlResidentialBuyPropertyTypes > div.options > div:nth-child(2)"));
            selectHouse.Click();
        }

        public static void StartSearch()
        {
            var clickStart = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".search-button"));
            clickStart.Click();
        }

        public static void WaitForMap()
        {
            WebDriverWait waitForMapToLoad = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForMapToLoad.Until(ExpectedConditions.ElementIsVisible(By.ClassName("gmnoprint")));
        }

        public static void BetaAdminCMSLoginButton()
        {
            var betaLogIn = SeleniumHelper.WebDriver.FindElement(By.Id("ContentPlaceHolder2_Login1_LoginButton"));
            betaLogIn.Click();
        }

        public static void officeTabClick()
        {
            var clickPeopleOffice = SeleniumHelper.WebDriver.FindElement(By.Id("cpMain_ucc1_ctl00_liTabPeople"));
            clickPeopleOffice.Click();

            var clickOfficeToggle = SeleniumHelper.WebDriver.FindElement(By.Id("cpMain_ucc1_ctl00_liPeople"));
            clickOfficeToggle.Click();
        }
    }
}
