using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Xunit;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using KnightFrank.Tests.Regression;
using KnightFrank.Tests.Regression.Model;

namespace KnightFrank.Blog.Tests.Regression.Steps
{
    [Binding]
    public class UserStory64484BlogHomepage_SearchEnhancementsSteps
    {
        public IWebDriver WebDriver;
        [Given(@"user has visited the blog homepage")]
        public void GivenUserHasVisitedTheBlogHomepage()
        {
            SeleniumHelper.SetUpDriver();

            SeleniumHelper.ValidateBlog();
        }
        
        [Given(@"opened the search feature")]
        public void GivenOpenedTheSearchFeature()
        {
            SeleniumHelper.OpenTheBlogSearch();
        }

        [Then(@"User should see placeholder")]
        public void ThenUserShouldSeePlaceholder(Table table)
        {
            var blogSearchTerm = table.CreateInstance<BlogSearch>();

            var placeHolderText = WebDriver.FindElement(By.ClassName("watermark")).Text;

            Assert.Equal(placeHolderText, blogSearchTerm.Placeholder);
        }


        [When(@"user enters a valid search term with upper and lower case characters")]
        public void WhenUserEntersAValidSearchTermWithUpperAndLowerCaseCharacters(Table table)
        {
            var blogSearchTerm = table.CreateInstance<BlogSearch>();

            var searchTextOne = WebDriver.FindElement(By.Id("SearchTerm2"));
            searchTextOne.SendKeys(blogSearchTerm.SearchTerm);
        }

        [When(@"user enters a valid search term using characters with quotations")]
        public void WhenUserEntersAValidSearchTermUsingCharactersWithQuotations(Table table)
        {
            var blogSearchTerm = table.CreateInstance<BlogSearch>();

            var searchTextTwo = WebDriver.FindElement(By.Id("SearchTerm2"));
            searchTextTwo.SendKeys(blogSearchTerm.SearchTerm);
        }

        [When(@"user enters a valid search term with characters and numbers")]
        public void WhenUserEntersAValidSearchTermWithCharactersAndNumbers(Table table)
        {
            var blogSearchTerm = table.CreateInstance<BlogSearch>();

            var searchTextThree = WebDriver.FindElement(By.Id("SearchTerm2"));
            searchTextThree.SendKeys(blogSearchTerm.SearchTerm);
        }

        [When(@"press the return key")]
        public void WhenPressTheReturnKey()
        {
            SeleniumHelper.PressTheReturnKey();
        }

        [Then(@"user should see a list of related results")]
        public void ThenUserShouldSeeAListOfRelatedResults()
        {
            SeleniumHelper.ValidateResult();
        }
    }
}
