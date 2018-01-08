using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Xunit;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using KnightFrank.Tests.Regression.Model;
using KnightFrank.Blog.Tests.Regression.Model;
using System.Collections.Generic;
using KnightFrank.Blog.Tests.Regression;

namespace KnightFrank.Tests.Regression
{
    [Binding]
    public class PropertySearchUsingPropertyReferenceSteps
    {
        public IWebDriver WebDriver;
        [Given(@"user has visited the knight frank homepage")]
        public void GivenUserHasVisitedTheKnightFrankHomepage()
        {
            SeleniumHelper.SetUpHomepage();
        }

        [Then(@"user has visited knight Frank ""(.*)""")]
        public void GivenUserHasVisitedKnightFrank(string site, Table table)
        {
            var domainSettingsList = table.CreateSet<DomainSettings>();

            foreach (var ds in domainSettingsList)
            {
                WebDriver.Url = "http://" + ds.Website;
                WebDriverWait waitForCountry = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
                waitForCountry.Until(ExpectedConditions.ElementExists(By.CssSelector(".header-list .dropdown > a#dropdownMenu2")));
                var currentLanguges = WebDriver.FindElements(By.CssSelector(".header-list .dropdown > a#dropdownMenu1"));
                if (currentLanguges.Count > 0)
                {
                    Assert.True(currentLanguges[0].Text.Contains(ds.Language), "language does not match");
                }
                else if (String.IsNullOrEmpty(ds.Language))
                {
                    Assert.True(true, "found element when should not");
                }
                
            }
        }

        [When(@"user enters a valid property reference at the end of the url")]
        public void WhenUserEntersAValidPropertyReferenceAtTheEndOfTheUrl(Table table)
        {
            var property = table.CreateInstance<Property>();
      
            SeleniumHelper.WebDriver.Navigate().GoToUrl("http://beta.knightfrank.co.uk/" + property.Reference);
        }


        [When(@"user enters a valid property reference")]
        public void WhenUserEntersAValidPropertyReference(Table table)
        {
            SeleniumHelper.ResTabClick();

            var property = table.CreateInstance<Property>();

            var enterRef = SeleniumHelper.WebDriver.FindElement(By.Id("cpMain_ucc1_ctl00_txtResidentialSearchBox"));
            enterRef.SendKeys(property.Reference);

            WebDriverWait waitForAuto = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForAuto.Until(ExpectedConditions.ElementIsVisible(By.Id("ui-id-5")));

            var autoSelect = SeleniumHelper.WebDriver.FindElement(By.Id("ui-id-5"));
            autoSelect.Click();
        }

        [When(@"user enters a valid postcode")]
        public void WhenUserEntersAValidPostcode(Table table)
        {
            SeleniumHelper.ResTabClick();

            var property = table.CreateInstance<Property>();

            var enterPostCode = SeleniumHelper.WebDriver.FindElement(By.Id("cpMain_ucc1_ctl00_txtResidentialSearchBox"));
            enterPostCode.SendKeys(property.Postcode);

            WebDriverWait waitForAuto = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForAuto.Until(ExpectedConditions.ElementIsVisible(By.Id("ui-id-5")));

            var autoSelect = SeleniumHelper.WebDriver.FindElement(By.Id("ui-id-5"));
            autoSelect.Click();
        }

        [When(@"user enters a valid Country")]
        public void WhenUserEntersAValidCountry(Table table)
        {
            SeleniumHelper.ResTabClick();

            var property = table.CreateInstance<Property>();

            var enterCountry = SeleniumHelper.WebDriver.FindElement(By.Id("cpMain_ucc1_ctl00_txtResidentialSearchBox"));
            enterCountry.SendKeys(property.Country);

            WebDriverWait waitForAuto = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForAuto.Until(ExpectedConditions.ElementIsVisible(By.Id("ui-id-5")));

            var autoSelect = SeleniumHelper.WebDriver.FindElement(By.Id("ui-id-5"));
            autoSelect.Click();
        }

        [When(@"selects the house filter")]
        public void WhenSelectsTheHouseFilter()
        {
            SeleniumHelper.HouseFilter();
        }

        [When(@"clicks the search button")]
        public void WhenClicksTheSearchButton()
        {
            SeleniumHelper.StartSearch();
        }

        [Then(@"user should be taken directly to the PDP page of the property")]
        public void ThenUserShouldBeTakenDirectlyToThePDPPageOfTheProperty()
        {
            WebDriverWait waitForPDP = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(30));
            waitForPDP.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".contact-agent")));

            Assert.Equal("http://beta.knightfrank.co.uk/properties/residential/for-sale/one-hyde-park-knightsbridge-london-sw1x/sla130404", SeleniumHelper.WebDriver.Url);
        }

        [Then(@"user should be taken to results for that postcode area")]
        public void ThenUserShouldBeTakenToResultsForThatPostcodeArea()
        {
            SeleniumHelper.WaitForMap();

            var postcodeResults = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".lead h1")).Text;
            Assert.Contains("Properties for sale in SW4", postcodeResults);
        }

        [Then(@"user should be taken to results for that postcode area and houses as a property type")]
        public void ThenUserShouldBeTakenToResultsForThatPostcodeAreaAndHousesAsAPropertyType()
        {
            var postcodeHouseUrl = SeleniumHelper.WebDriver.Url;
            string UrlPostcodeHouse = postcodeHouseUrl;
            Assert.Contains("sw4", UrlPostcodeHouse);

            SeleniumHelper.WaitForMap();

            var thumbnailHouse = SeleniumHelper.WebDriver.FindElement(By.XPath("//div/section[6]/div[2]/div[1]/div[1]/property/div/a/div/div[4]")).Text;
            true.Equals(thumbnailHouse.Contains("House"));
        }

        [Then(@"user should be taken to results for that Country")]
        public void ThenUserShouldBeTakenToResultsForThatCountry()
        {
            var countryResults = SeleniumHelper.WebDriver.FindElement(By.XPath("//div/section[6]/div[1]/div/div/div[1]/div/h1")).Text;
            Assert.Contains("Properties for sale in Germany", countryResults);
        }
    }
}
