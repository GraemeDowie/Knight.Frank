using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Xunit;
using TechTalk.SpecFlow;


namespace KnightFrank.Blog.Tests.Regression
{
    [Binding]
    public class BlogListing_DisplayPinnedListingSettingForBlogPostsSteps
    {
        [Then(@"user should see the first three articles are pinned posts")]
        public void ThenUserShouldSeeTheFirstThreeArticlesArePinnedPosts()
        {
            //this webdriver initialised in SearchEnhancement steps
            var pinPosts = SeleniumHelper.WebDriver.FindElements(By.CssSelector(".pinned-post"));
            Assert.True(pinPosts.Count == 3);

            foreach (var pp in pinPosts)
            {
                Assert.Equal("rgba(0, 0, 0, 0)", pp.GetCssValue("background-color"));
            }
        }

        [Then(@"user should see four Featured posts in the hero area")]
        public void ThenUserShouldSeeFourFeaturedPostsInTheHeroArea()
        {
            //this webdriver initialised in SearchEnhancement steps
            var featPost = SeleniumHelper.WebDriver.FindElements(By.CssSelector(".fet-art-sm"));
            Assert.True(featPost.Count == 4);
        }

    }
}
