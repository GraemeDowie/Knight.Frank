using KnightFrank.Tests.Regression;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Linq;

namespace KnightFrank.Blog.Tests.Regression
{
    [Binding]
    public class CMSFiltersAreCorrectSteps
    {
        public static IWebDriver WebDriver;
        [Given(@"user has visited knight frank homepage")]
        public void GivenUserHasVisitedKnightFrankHomepage()
        {
            SeleniumHelper.SetUpHomepage();
        }
        
        [When(@"user opens the distance filter")]
        public void WhenUserOpensTheDistanceFilter()
        {
            SeleniumHelper.ResTabClick();

            var selectDistanceFilter = WebDriver.FindElement(By.Id("simpleselect_cpMain_ucc1_ctl00_ddlResidentialBuyDistance"));
            selectDistanceFilter.Click();
        }

        [Then(@"user should see all distance (.*) filter options")]
        public void ThenUserShouldSeeAllDistanceFilterOptions(string distanceOptions)
        {
            var distanceOpen = WebDriver.FindElement(By.CssSelector("#simpleselect_cpMain_ucc1_ctl00_ddlResidentialBuyDistance"));
            Assert.Contains(distanceOptions, distanceOpen.Text);
        }


        [Then(@"user should see (.*) distance values")]
        public void ThenUserShouldSeeDistanceValues(string distance)
        {
            var distanceOpen = WebDriver.FindElement(By.CssSelector("#simpleselect_cpMain_ucc1_ctl00_ddlResidentialBuyDistance"));
            Assert.Contains(distance, distanceOpen.Text);
        }

        [When(@"user opens the property types filter")]
        public void WhenUserOpensThePropertyTypesFilter()
        {
            SeleniumHelper.ResTabClick();

            var selectPropertyFilter = SeleniumHelper.WebDriver.FindElement(By.Id("simpleselect_cpMain_ucc1_ctl00_ddlResidentialBuyPropertyTypes"));
            selectPropertyFilter.Click();
        }

        [Then(@"user should see (.*) property values")]
        public void ThenUserShouldSeePropertyValues(string property)
        {
            var propertyOpen = SeleniumHelper.WebDriver.FindElement(By.CssSelector("#simpleselect_cpMain_ucc1_ctl00_ddlResidentialBuyPropertyTypes"));
            Assert.Contains(property, propertyOpen.Text);
        }

        [When(@"user opens the bedroom filter")]
        public void WhenUserOpensTheBedroomFilter()
        {
            SeleniumHelper.ResTabClick();

            var selectBedroomFilter = SeleniumHelper.WebDriver.FindElement(By.Id("simpleselect_cpMain_ucc1_ctl00_ddlResidentialBuyBedrooms"));
            selectBedroomFilter.Click();
        }

        [Then(@"user should see (.*) bedroom values")]
        public void ThenUserShouldSeeBedroomValues(string bedroom)
        {
            var bedroomOpen = SeleniumHelper.WebDriver.FindElement(By.CssSelector("#simpleselect_cpMain_ucc1_ctl00_ddlResidentialBuyBedrooms"));
            Assert.Contains(bedroom, bedroomOpen.Text);
        }

        [When(@"user opens commercial property type filter")]
        public void WhenUserOpensCommercialPropertyTypeFilter()
        {
            SeleniumHelper.comTabClick();

            var selectComPropertyType = SeleniumHelper.WebDriver.FindElement(By.Id("simpleselect_cpMain_ucc1_ctl00_ddlCommercialRentPropertyTypes"));
            selectComPropertyType.Click();
        }

        [Then(@"user should see commercial (.*) property types")]
        public void ThenUserShouldSeeCommercialPropertyTypes(string comPropertyTypes)
        {
            var comPropertyOpen = SeleniumHelper.WebDriver.FindElement(By.CssSelector("#simpleselect_cpMain_ucc1_ctl00_ddlCommercialRentPropertyTypes"));
            Assert.Contains(comPropertyTypes, comPropertyOpen.Text);
        }

        [When(@"user opens commercial Floor area filter")]
        public void WhenUserOpensCommercialFloorAreaFilter()
        {
            SeleniumHelper.comTabClick();

            var selectComFloorArea = SeleniumHelper.WebDriver.FindElement(By.Id("simpleselect_cpMain_ucc1_ctl00_ddlCommercialRentFloorArea"));
            selectComFloorArea.Click();
        }

        [Then(@"user should see commercial (.*) floor area")]
        public void ThenUserShouldSeeCommercialFloorArea(string comFloorArea)
        {
            var comFloorOpen = SeleniumHelper.WebDriver.FindElement(By.CssSelector("#simpleselect_cpMain_ucc1_ctl00_ddlCommercialRentFloorArea"));
            Assert.Contains(comFloorArea, comFloorOpen.Text);
        }


    }
}
