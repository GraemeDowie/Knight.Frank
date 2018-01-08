using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;

using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace KnightFrank.Blog.Tests.Regression.StepsCMS
{
    [Binding]
    public class KnightFrankRussiaWebsiteSteps
    {
        [Given(@"user has visited Knight Frank Russia domain")]
        public void GivenUserHasVisitedKnightFrankRussiaDomain()
        {
            SeleniumHelper.WebDriver.Url = "http://beta.knightfrank.ru";
            SeleniumHelper.WebDriver.Manage().Window.Maximize();
        }
        
        [Then(@"user should see (.*) site Global Navigation")]
        public void ThenUserShouldSeeSiteGlobalNavigation(string russiaGlobalNav)
        {
            var globalRussiaNav = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".hidden-sm-down"));
            Assert.Contains(russiaGlobalNav, globalRussiaNav.Text);
        }

        [Then(@"user should see (.*) site navigation")]
        public void ThenUserShouldSeeSiteNavigation(string russiaSiteNav)
        {
            var siteRussiaNav = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".main-navigation"));
            Assert.Contains(russiaSiteNav, siteRussiaNav.Text);
        }

        [Then(@"user should see (.*) search box tabs")]
        public void ThenUserShouldSeeSearchBoxTabs(string russiaSearchTabs)
        {
            var searchRussiaTabs = SeleniumHelper.WebDriver.FindElement(By.Id("cpMain_ucc1_ctl00_ulSearchNav"));
            Assert.Contains(russiaSearchTabs, searchRussiaTabs.Text);
        }

        [Then(@"user should see the russia search box text")]
        public void ThenUserShouldSeeTheRussiaSearchBoxText(Table table)
        {
            var waterMark = table.CreateInstance<placeHolder>();

            var russiaSearchField = SeleniumHelper.WebDriver.FindElement(By.Id("cpMain_ucc1_ctl00_lblRussiaSearchText"));
            Assert.Contains(russiaSearchField.Text, waterMark.searchWaterMark);
        }

    }
}
