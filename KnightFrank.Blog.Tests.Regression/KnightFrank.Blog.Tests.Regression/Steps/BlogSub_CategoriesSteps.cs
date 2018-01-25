using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Xunit;
using TechTalk.SpecFlow;

namespace KnightFrank.Blog.Tests.Regression.Steps
{
    [Binding]
    public class BlogSub_CategoriesSteps
    {
        [When(@"user clicks on the property category")]
        public void WhenUserClicksOnThePropertyCategory()
        {
            SeleniumHelper.clickPropertyNavigation();
        }
        
        [When(@"clicks on the property sub nav bar")]
        public void WhenClicksOnThePropertySubNavBar()
        {
            SeleniumHelper.clickSubNavigationBar();
        }
        
        [Then(@"user should see a list of property sub categories (.*)")]
        public void ThenUserShouldSeeAListOfPropertySubCategories(string propSubCat)
        {
            var subDropdown = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".resultsBar"));
            Assert.Contains(propSubCat, subDropdown.Text);
        }


        [When(@"user clicks on the news category")]
        public void WhenUserClicksOnTheNewsCategory()
        {
            SeleniumHelper.clickNewsNavigation();
        }

        [When(@"clicks on the news sub nav bar")]
        public void WhenClicksOnTheNewsSubNavBar()
        {
            SeleniumHelper.clickSubNavigationBar();
        }

        [Then(@"user should see a list of news sub categories (.*)")]
        public void ThenUserShouldSeeAListOfNewsSubCategories(string newsSubCat)
        {
            var subDropdown = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".resultsBar"));
            Assert.Contains(newsSubCat, subDropdown.Text);
        }


        [When(@"user clicks on the lifestyle category")]
        public void WhenUserClicksOnTheLifestyleCategory()
        {
            SeleniumHelper.clickLifestyleNavigation();
        }

        [When(@"clicks on the lifestyle sub nav bar")]
        public void WhenClicksOnTheLifestyleSubNavBar()
        {
            SeleniumHelper.clickSubNavigationBar();
        }

        [Then(@"user should see a list of lifestyle sub categories (.*)")]
        public void ThenUserShouldSeeAListOfLifestyleSubCategories(string lifestyleSubCat)
        {
            var subDropdown = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".resultsBar"));
            Assert.Contains(lifestyleSubCat, subDropdown.Text);
        }


        [When(@"user clicks on the intelligence category")]
        public void WhenUserClicksOnTheIntelligenceCategory()
        {
            SeleniumHelper.clickIntelligenceNavigation();
        }

        [When(@"clicks on the intelligence sub nav bar")]
        public void WhenClicksOnTheIntelligenceSubNavBar()
        {
            SeleniumHelper.clickSubNavigationBar();
        }

        [Then(@"user should see a list of intelligence sub categories (.*)")]
        public void ThenUserShouldSeeAListOfIntelligenceSubCategories(string intelligenceSubCat)
        {
            var subDropdown = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".resultsBar"));
            Assert.Contains(intelligenceSubCat, subDropdown.Text);
        }

    }
}
