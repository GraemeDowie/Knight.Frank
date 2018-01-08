using KnightFrank.Tests.Regression;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Xunit;
using TechTalk.SpecFlow;

namespace KnightFrank.Blog.Tests.Regression.Steps
{
    [Binding]
    public class VideoForResidentialAndCommercialPlaySteps
    {
        [Given(@"user has visited knight frank homepage to play the video")]
        public void GivenUserHasVisitedKnightFrankHomepageToPlayTheVideo()
        {
            SeleniumHelper.WebDriver.Url = "http://beta.knightfrank.co.uk";
            SeleniumHelper.WebDriver.Manage().Window.Maximize();
        }


        [When(@"user selects Residential tab")]
        public void WhenUserSelectsResidentialTab()
        {
            var resTab = SeleniumHelper.WebDriver.FindElement(By.Id("cpMain_ucc1_ctl00_liTabResidential"));
            resTab.Click();
        }

        [When(@"user selects Commercial tab")]
        public void WhenUserSelectsCommercialTab()
        {
            var comTab = SeleniumHelper.WebDriver.FindElement(By.Id("cpMain_ucc1_ctl00_liTabCommercial"));
            comTab.Click();
        }


        [When(@"presses the video play icon")]
        public void WhenPressesTheVideoPlayIcon()
        {
            var videoIcon = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".play")).GetCssValue("text-align");
            Assert.True(videoIcon == "center");

            var videoIconClick = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".play"));
            videoIconClick.Click();
        }
        
        [Then(@"a video should begin to play")]
        public void ThenAVideoShouldBeginToPlay()
        {
            WebDriverWait waitForVideo = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForVideo.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".video-wrapper")));

            var videoPlaying = SeleniumHelper.WebDriver.FindElement(By.Id("cpMain_ucc2_ctl00_videoSection")).GetCssValue("visibility");
            Assert.True(videoPlaying == "visible");

            WebDriverWait waitForClose = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForClose.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#cpMain_ucc2_ctl00_divSection > div.video-wrapper > i")));

            var closeVideo = SeleniumHelper.WebDriver.FindElement(By.CssSelector("#cpMain_ucc2_ctl00_divSection > div.video-wrapper > i"));
            closeVideo.Click();
        }
    }
}
