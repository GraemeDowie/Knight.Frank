using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Xunit;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace KnightFrank.Blog.Tests.Regression.StepsCMS
{
    [Binding]
    public class OfficePageNewSteps
    {
        [Given(@"user has visited Leeds office page")]
        public void GivenUserHasVisitedLeedsOfficePage(Table table)
        {
            var leedsOffice = table.CreateInstance<leedsPage>();

            SeleniumHelper.WebDriver.Url = leedsOffice.officePage;
            SeleniumHelper.WebDriver.Manage().Window.Maximize();
        }
        
        [Then(@"user should see (.*) global navigation")]
        public void ThenUserShouldSeeGlobalNavigation(string globalNav)
        {
            var navigation = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".header-list"));
            Assert.Contains(globalNav, navigation.Text);
        }

        [Then(@"my knight frank on the global nav should be red")]
        public void ThenMyKnightFrankOnTheGlobalNavShouldBeRed(Table table)
        {
            var myKFRed = table.CreateInstance<myFK>();

            var myKnightFrank = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".header-list > ul > li:nth-child(5) > a")).GetCssValue("color");
            Assert.Contains(myKnightFrank, myKFRed.myKnightFrankRed);
        }

        [Then(@"user should see (.*) site nav")]
        public void ThenUserShouldSeeSiteNav(string siteNav)
        {
            var nav = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".main-navigation"));
            Assert.Contains(siteNav, nav.Text);
        }

        [Then(@"user sees site nav bar is green")]
        public void ThenUserSeesSiteNavBarIsGreen(Table table)
        {
            var siteNav = table.CreateInstance<siteGreen>();

            var greenNav = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".navigation")).GetCssValue("background-color");
            Assert.Contains(greenNav, siteNav.siteNavGreen);
        }

        [Then(@"user should see the image in the search area")]
        public void ThenUserShouldSeeTheImageInTheSearchArea(Table table)
        {
            var imageUrl = table.CreateInstance<leedsImg>();

            var backImg = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".search-area")).GetCssValue("background-image");
            Assert.Contains(backImg, imageUrl.leedsImage);
        }

        [Then(@"user should see the (.*) search box tab options")]
        public void ThenUserShouldSeeTheSearchBoxTabOptions(string searchBoxTabs)
        {
            var searchTabs = SeleniumHelper.WebDriver.FindElement(By.CssSelector("#cpMain_ucc1_ctl00_ulSearchNav"));
            Assert.Contains(searchBoxTabs, searchTabs.Text);
        }

    }
}
