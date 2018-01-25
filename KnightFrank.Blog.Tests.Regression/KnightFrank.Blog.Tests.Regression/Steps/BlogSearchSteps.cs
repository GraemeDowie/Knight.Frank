using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Xunit;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Linq;

namespace KnightFrank.Blog.Tests.Regression.Steps
{
    [Binding]
    public class BlogSearchSteps
    {
        [Then(@"user should see the blog search icon in the top navigation")]
        public void ThenUserShouldSeeTheBlogSearchIconInTheTopNavigation()
        {
            SeleniumHelper.WebDriver.Title.Contains("Blog");

            var searchIcon = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".fa-search"));
            Assert.True(searchIcon.Enabled);
            Assert.Equal("24px", searchIcon.GetCssValue("font-size"));
        }


        [When(@"user clicks the Blog search icon")]
        public void WhenUserClicksTheBlogSearchIcon()
        {
            SeleniumHelper.WebDriver.Title.Contains("Blog");

            var clickSearchButton = SeleniumHelper.WebDriver.FindElement(By.CssSelector("social-nav > div.global-social.social > a.searchTrigger.dropNavItem > i"));
            clickSearchButton.Click();
        }

        [Then(@"the blog search should open and the user should see the words Search the blog")]
        public void ThenTheBlogSearchShouldOpenAndTheUserShouldSeeTheWordsSearchTheBlog(Table table)
        {
            var searchWatermark = table.CreateInstance<BlogWaterMark>();

            var searchArea = SeleniumHelper.WebDriver.FindElement(By.CssSelector("#SearchContainer"));
            Assert.Equal(searchWatermark.blogWatermark, searchArea.Text);

            var redSearchIcon = SeleniumHelper.WebDriver.FindElement(By.CssSelector("#SearchContainer > div > a > i"));
            Assert.Equal("rgba(208, 16, 58, 1)", redSearchIcon.GetCssValue("color"));
        }

        [When(@"performs a free text search for posts with a valid search term (.*)")]
        public void WhenPerformsAFreeTextSearchForPostsWithAValidSearchTerm(string blogSearchInput)
        {
            var blogSearchBox = SeleniumHelper.WebDriver.FindElement(By.Id("SearchTerm2"));
            blogSearchBox.SendKeys(blogSearchInput);

            var startBlogSearch = SeleniumHelper.WebDriver.FindElement(By.CssSelector("#SearchContainer > div > a > i"));
            startBlogSearch.Click();
        }


        [Then(@"user should see a grid of returned articles featuring the valid search term")]
        public void ThenUserShouldSeeAGridOfReturnedArticlesFeaturingTheValidSearchTerm()
        {
            WebDriverWait waitForResults = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(30));
            waitForResults.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".thumb:nth-child(10)")));

            var blogResultsText = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".alert > p"));

            var loadMore = SeleniumHelper.WebDriver.FindElements(By.CssSelector(".load-more-button")).FirstOrDefault();

            var blogCount = Int32.Parse(blogResultsText.Text.Split(' ')[0]);

            if (blogCount > 24)
            {
                Assert.True(loadMore.Displayed);
            }
            else if (blogCount <= 24)
            {
                Assert.Null(loadMore);
            }
        }
    }
}
