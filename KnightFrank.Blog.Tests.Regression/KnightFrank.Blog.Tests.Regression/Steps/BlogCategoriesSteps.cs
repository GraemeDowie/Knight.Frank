using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Xunit;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace KnightFrank.Blog.Tests.Regression.Steps
{
    [Binding]
    public class BlogCategoriesSteps
    {
        [Then(@"user should see a list of categories in the top navigation (.*)")]
        public void ThenUserShouldSeeAListOfCategoriesInTheTopNavigation(string blogCategories)
        {
            var blogNavBar = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".navbar-nav"));
            Assert.Contains(blogCategories, blogNavBar.Text);
        }

        [Then(@"User should see the All Categories selected with a red background")]
        public void ThenUserShouldSeeTheAllCategoriesSelectedWithARedBackground()
        {
            var allCatSelected = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".all-categories")).GetAttribute("class");
            Assert.Equal("all-categories active", allCatSelected);

            var allCatColor = SeleniumHelper.WebDriver.FindElement(By.CssSelector("blog-nav > nav > ul > li.all-categories.active > a")).GetCssValue("background-color");
            Assert.Equal("rgba(208, 16, 58, 1)", allCatColor);
        }

        [When(@"user selects the Property category")]
        public void WhenUserSelectsThePropertyCategory()
        {
            var clickProperty = SeleniumHelper.WebDriver.FindElement(By.CssSelector("blog-nav > nav > ul > li.property > a"));
            clickProperty.Click();

            var propertyUrl = SeleniumHelper.WebDriver.Url;
            Assert.Equal("http://beta.knightfrank.co.uk/blog/category/property", propertyUrl);
        }

        [Then(@"the background color should be correct")]
        public void ThenTheBackgroundColorShouldBeCorrect(Table table)
        {
            var propColor = table.CreateInstance<PropertyBGColor>();

            var confirmPropertyColor = SeleniumHelper.WebDriver.FindElement(By.CssSelector("blog-nav > nav > ul > li.property.active > a")).GetCssValue("background-color");
            Assert.Equal(propColor.propertyBGColor, confirmPropertyColor);
        }

        [Then(@"the class should be active")]
        public void ThenTheClassShouldBeActive()
        {
            var propertyActive = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".property")).GetAttribute("class");
            Assert.Equal("panel panel-default property active", propertyActive);
        }

        [When(@"user selects the News category")]
        public void WhenUserSelectsTheNewsCategory()
        {
            var clickNews = SeleniumHelper.WebDriver.FindElement(By.CssSelector("blog-nav > nav > ul > li.news > a"));
            clickNews.Click();
        }

        [Then(@"the News background color should be correct")]
        public void ThenTheNewsBackgroundColorShouldBeCorrect(Table table)
        {
            var newsColor = table.CreateInstance<NewsBGColor>();

            var confirmNewsColor = SeleniumHelper.WebDriver.FindElement(By.CssSelector("blog-nav > nav > ul > li.news.active > a")).GetCssValue("background-color");
            Assert.Equal(newsColor.newsBGColor, confirmNewsColor);
        }

        [Then(@"the News class should be active")]
        public void ThenTheNewsClassShouldBeActive()
        {
            var newsActive = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".news")).GetAttribute("class");
            Assert.Equal("panel panel-default news active", newsActive);
        }

        [When(@"user selects the Lifestyle category")]
        public void WhenUserSelectsTheLifestyleCategory()
        {
            var clickLifestyle = SeleniumHelper.WebDriver.FindElement(By.CssSelector("blog-nav > nav > ul > li.lifestyle > a"));
            clickLifestyle.Click();
        }

        [Then(@"the Lifestyle background color should be correct")]
        public void ThenTheLifestyleBackgroundColorShouldBeCorrect(Table table)
        {
            var lifestyleColor = table.CreateInstance<LifestyleBGColor>();

            var confirmLifestyleColor = SeleniumHelper.WebDriver.FindElement(By.CssSelector("blog-nav > nav > ul > li.lifestyle.active > a")).GetCssValue("background-color");
            Assert.Equal(lifestyleColor.lifestyleBGColor, confirmLifestyleColor);
        }

        [Then(@"the Lifestyle class should be active")]
        public void ThenTheLifestyleClassShouldBeActive()
        {
            var lifestyleActive = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".lifestyle")).GetAttribute("class");
            Assert.Equal("panel panel-default lifestyle active", lifestyleActive);
        }

        [When(@"user selects the Intelligence category")]
        public void WhenUserSelectsTheIntelligenceCategory()
        {
            var clickIntelligence = SeleniumHelper.WebDriver.FindElement(By.CssSelector("blog-nav > nav > ul > li.intelligence > a"));
            clickIntelligence.Click();
        }

        [Then(@"the Intelligence background color should be correct")]
        public void ThenTheIntelligenceBackgroundColorShouldBeCorrect(Table table)
        {
            var intelligenceColor = table.CreateInstance<IntelligenceBGColor>();

            var confirmIntelligenceColor = SeleniumHelper.WebDriver.FindElement(By.CssSelector("blog-nav > nav > ul > li.intelligence.active > a")).GetCssValue("background-color");
            Assert.Equal(intelligenceColor.intelligenceBGColor, confirmIntelligenceColor);
        }

        [Then(@"the Intelligence class should be active")]
        public void ThenTheIntelligenceClassShouldBeActive()
        {
            var intelligenceActive = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".intelligence")).GetAttribute("class");
            Assert.Equal("panel panel-default intelligence active", intelligenceActive);
        }

    }
}
