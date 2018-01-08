using KnightFrank.Tests.Regression;
using OpenQA.Selenium;
using Xunit;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.Support.UI;

namespace KnightFrank.Blog.Tests.Regression
{
    [Binding]
    public class CMSNavigationSteps
    {
        public IWebDriver WebDriver;
        [Then(@"user should see (.*) Green Navigation")]
        public void ThenUserShouldSeeGreenNavigation(string greenNav)
        {
            var greenNavBar = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".main-navigation"));
            Assert.Contains(greenNav, greenNavBar.Text);
        }

        [Then(@"user should see (.*) Search Tabs")]
        public void ThenUserShouldSeeSearchTabs(string searchTabs)
        {
            var searchTab = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".search-nav"));
            Assert.Contains(searchTabs, searchTab.Text);
        }

        [When(@"user searchs for (.*) location")]
        public void WhenUserSearchsForLocation(string location)
        {
            var search = SeleniumHelper.WebDriver.FindElement(By.Id("cpMain_ucc1_ctl00_txtResidentialSearchBox"));
            search.SendKeys(location);

            WebDriverWait waitForAuto = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForAuto.Until(ExpectedConditions.ElementIsVisible(By.Id("ui-id-5")));

            var autoSuggest = SeleniumHelper.WebDriver.FindElement(By.Id("ui-id-5"));
            autoSuggest.Click();

            var startSearch = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".search-button"));
            startSearch.Click();
        }

        [When(@"results are returned the (.*) Global Navigation should be visible")]
        public void WhenResultsAreReturnedTheGlobalNavigationShouldBeVisible(string globalNav)
        {
            WebDriverWait waitForMap = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(10));
            waitForMap.Until(ExpectedConditions.ElementIsVisible(By.ClassName("gmnoprint")));

            var searchNav = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".header-list"));

            Assert.Contains(globalNav, searchNav.Text);
        }

    }
}
