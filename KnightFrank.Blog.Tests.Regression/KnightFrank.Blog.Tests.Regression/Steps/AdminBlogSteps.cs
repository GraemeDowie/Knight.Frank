using KnightFrank.Tests.Regression;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

namespace KnightFrank.Blog.Tests.Regression
{
    [Binding]
    public class BlogAdminSteps
    {
        public static IWebDriver WebDriver;
        [Given(@"user has visited the Blog admin")]
        public void GivenUserHasVisitedTheBlogAdmin()
        {
            SeleniumHelper.SetUpAdminDriver();
           
        }

        [When(@"user enters valid log in details")]
        public void WhenUserEntersValidLogInDetails(Table table)
        {
            WebDriverWait waitForLogin = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForLogin.Until(ExpectedConditions.ElementIsVisible(By.Id("Email")));

            var blogLogin = table.CreateInstance<UserDetails>();

            var enterEmail = SeleniumHelper.WebDriver.FindElement(By.Id("Email"));
            enterEmail.SendKeys(blogLogin.userName);

            var enterPassword = SeleniumHelper.WebDriver.FindElement(By.Id("Password"));
            enterPassword.SendKeys(blogLogin.password);

            var clickLogIn = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".btn-primary"));
            clickLogIn.Click();
        }

        [Then(@"user should be on the Blog Dashboard page")]
        public void ThenUserShouldBeOnTheBlogDashboardPage()
        {
            WebDriverWait waitForDash = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForDash.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".dashboard-grid")));

            var dashBoard = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".dashboard-grid"));

            Assert.True(dashBoard.Displayed);
        }

        [When(@"user clicks on the tag link from the side nav")]
        public void WhenUserClicksOnTheTagLinkFromTheSideNav()
        {
            var contents = SeleniumHelper.WebDriver.FindElement(By.ClassName("contents"));
            contents.Click();

            WebDriverWait waitForTagOption = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForTagOption.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#collapsePosts > ul > li:nth-child(2) > a")));

            var selectTags = SeleniumHelper.WebDriver.FindElement(By.CssSelector("#collapsePosts > ul > li:nth-child(2) > a"));
            selectTags.Click();
        }

        [When(@"clicks to add a tag")]
        public void WhenClicksToAddATag()
        {
            var addTag = SeleniumHelper.WebDriver.FindElement(By.ClassName("create"));
            addTag.Click();
        }

        [When(@"user enters a valid tag name")]
        public void WhenUserEntersAValidTagName(Table table)
        {
            var tagText = table.CreateInstance<tagDetails>();

            var enterTag = SeleniumHelper.WebDriver.FindElement(By.Id("Tag_Name"));
            enterTag.SendKeys(tagText.tagName);

            var createTag = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".btn-primary"));
            createTag.Click();
        }

        [Then(@"user should be on tag management list page with the created tag")]
        public void ThenUserShouldBeOnTagManagementListPageWithTheCreatedTag()
        {
            WebDriverWait waitForGrid = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForGrid.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".dashboard-grid h4")));

            var tagVisible = SeleniumHelper.WebDriver.FindElement(By.TagName("tbody"));

            Assert.Contains("Automated Test", tagVisible.Text);
        }


        [When(@"I select Posts from the Contents drop down press Add post")]
        public void WhenISelectPostsFromTheContentsDropDownPressAddPost()
        {
            var clickContentsCreate = SeleniumHelper.WebDriver.FindElement(By.ClassName("contents"));
            clickContentsCreate.Click();

            WebDriverWait waitForPost = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForPost.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#collapsePosts > ul > li:nth-child(1) > a")));

            var selectPosts = SeleniumHelper.WebDriver.FindElement(By.CssSelector("#collapsePosts > ul > li:nth-child(1) > a"));
            selectPosts.Click();

            var addPost = SeleniumHelper.WebDriver.FindElement(By.ClassName("create"));
            addPost.Click();
        }

        [Then(@"I should be on the Post Management Create page")]
        public void ThenIShouldBeOnThePostManagementCreatePage()
        {
            var pmCreate = SeleniumHelper.WebDriver.FindElement(By.CssSelector("div.dashboard-grid h4"));
            string postCreate = pmCreate.Text;
            Assert.Equal("Posts Management - Create", postCreate);
        }

        [When(@"I enter a page title subtitle and content")]
        public void WhenIEnterAPageTitleSubtitleAndContent()
        {
            var enterTitle = SeleniumHelper.WebDriver.FindElement(By.Id("Title"));
            enterTitle.SendKeys("Automated Test Post - This is for Test Purpose ONLY");

            var enterSubtitle = SeleniumHelper.WebDriver.FindElement(By.Id("SubTitle_ifr"));
            enterSubtitle.SendKeys(" Automated Test Post - This is for Test Purpose ONLY ");

            var tinyMceBold = SeleniumHelper.WebDriver.FindElement(By.Id("mceu_43"));
            tinyMceBold.Click();

            enterSubtitle.SendKeys(" Automated Test Post - This is for Test Purpose ONLY ");

            var enterContent = SeleniumHelper.WebDriver.FindElement(By.Id("Content_ifr"));
            enterContent.SendKeys(" Automated Test Post - This is for Test Purpose ONLY");

            var tinyMceContentBold = SeleniumHelper.WebDriver.FindElement(By.Id("mceu_4"));
            tinyMceContentBold.Click();

            enterContent.SendKeys(" Automated Test Post - This is for Test Purpose ONLY");
        }

        [When(@"click create post button")]
        public void WhenClickCreatePostButton()
        {
            var clickCreatePost = SeleniumHelper.WebDriver.FindElement(By.XPath("//div[1]/div[4]/div/input"));
            clickCreatePost.Click();
        }

        [Then(@"I should see the post on the Post Management List")]
        public void ThenIShouldSeeThePostOnThePostManagementList()
        {
            var postManagementList = SeleniumHelper.WebDriver.FindElement(By.CssSelector("div.dashboard-grid h4"));
            string pmlPage = postManagementList.Text;
            Assert.Equal("Posts Management - List", pmlPage);

            var postVisible = SeleniumHelper.WebDriver.FindElement(By.XPath("//div[2]/div/div/form/div[2]/div/table/tbody/tr[2]/td[2]/span"));
            string titleVisible = postVisible.Text;
            Assert.Equal("Automated Test Post - This is for Test Purpose ONLY", titleVisible);
        }

        [When(@"I click edit and Publishing detail button")]
        public void WhenIClickEditAndPublishingDetailButton()
        {
            var editPostButton = SeleniumHelper.WebDriver.FindElement(By.XPath("//div[2]/div/div/form/div[2]/div/table/tbody/tr[2]/td[5]/a[1]"));
            editPostButton.Click();

            var selectPublishingDetail = SeleniumHelper.WebDriver.FindElement(By.XPath("//span[2]"));
            selectPublishingDetail.Click();
        }

        [When(@"I enter a main image and a thumbnail image")]
        public void WhenIEnterAMainImageAndAThumbnailImage()
        {
            var enterMainImageFileName = SeleniumHelper.WebDriver.FindElement(By.Id("mediaMain"));
            enterMainImageFileName.SendKeys("image");

            WebDriverWait waitForMain = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForMain.Until(ExpectedConditions.ElementIsVisible(By.Id("ui-id-4")));

            var selectMainImage = SeleniumHelper.WebDriver.FindElement(By.Id("ui-id-11"));
            selectMainImage.Click();

            var enterThumbImageFileName = SeleniumHelper.WebDriver.FindElement(By.Id("mediaThumbnail"));
            enterThumbImageFileName.SendKeys("image");

            WebDriverWait waitForThumb = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForThumb.Until(ExpectedConditions.ElementIsVisible(By.Id("ui-id-5")));

            var selectThumbnail = SeleniumHelper.WebDriver.FindElement(By.Id("ui-id-14"));
            selectThumbnail.Click();
        }

        [When(@"select a domain")]
        public void WhenSelectADomain()
        {
            var checkboxUK = SeleniumHelper.WebDriver.FindElement(By.Id("cb88edcf0e-4b0c-4445-a360-48a5cb48427b"));
            checkboxUK.Click();
        }

        [When(@"Select a category for the post")]
        public void WhenSelectACategoryForThePost()
        {
            var categorySelect = SeleniumHelper.WebDriver.FindElement(By.Id("node2e88b530-3b01-4bf4-b6db-a96680ac1075_anchor"));
            categorySelect.Click();
        }

        [When(@"enter a Tag name")]
        public void WhenEnterATagName()
        {
            var enterTagText = SeleniumHelper.WebDriver.FindElement(By.Id("TagAutocomplete"));
            enterTagText.SendKeys("London");

            var enterTag = SeleniumHelper.WebDriver.FindElement(By.Id("addTag"));
            enterTag.Click();
        }

        [When(@"and an author name")]
        public void WhenAndAnAuthorName()
        {
            var enterAuthorName = SeleniumHelper.WebDriver.FindElement(By.Id("AuthorAutocomplete"));
            enterAuthorName.SendKeys("Graeme Dowie");

            WebDriverWait waitForAuthor = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForAuthor.Until(ExpectedConditions.ElementIsVisible(By.ClassName("ui-menu-item")));

            var clickAuthor = SeleniumHelper.WebDriver.FindElement(By.ClassName("ui-menu-item-wrapper"));
            clickAuthor.Click();
        }

        //[When(@"user sets a Status for the post")]
        //public void WhenUserSetsAStatusForThePost()
        //{
        //    var setStatus = SeleniumHelper.WebDriver.FindElement(By.Id("StatusId"));
        //    setStatus.Click();
        //    setStatus.SendKeys(Keys.PageDown);
        //    setStatus.Click();
        //}

        [When(@"click on publish options button")]
        public void WhenClickOnPublishOptionsButton()
        {
            var publishPost = SeleniumHelper.WebDriver.FindElement(By.XPath("//div[2]/div[12]/div/input[1]"));
            publishPost.Click();

            var backToPosts = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".page-status li a"));
            backToPosts.Click();
        }

        [Then(@"I should be on the post management list with completed post")]
        public void ThenIShouldBeOnThePostManagementListWithCompletedPost()
        {
            var publishedPostVisible = SeleniumHelper.WebDriver.FindElement(By.XPath("//div[2]/div/div/form/div[2]/div/table/tbody/tr[2]/td[2]/span"));
            string postName = publishedPostVisible.Text;
            Assert.Equal("Automated Test Post - This is for Test Purpose ONLY", postName);
        }


    }
}
