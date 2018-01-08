using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Xunit;
using TechTalk.SpecFlow;

namespace KnightFrank.Blog.Tests.Regression
{
    [Binding]
    public class UserStory66239Blog_UIChangesToArticlePagesSteps
    {
        public IWebDriver WebDriver;
        [Then(@"the all categories tab should be selected and background color is Red")]
        public void ThenTheAllCategoriesTabShouldBeSelectedAndBackgroundColorIsRed()
        {
            SeleniumHelper.AllCategoriesTab();
        }

        [When(@"User selects the intelligence Category")]
        public void WhenUserSelectsTheIntelligenceCategory()
        {
            SeleniumHelper.PressIntelligenceCategory();
        }

        [Then(@"the Intelligence category background should be Yellow")]
        public void ThenTheIntelligenceCategoryBackgroundShouldBeYellow()
        {
            SeleniumHelper.IntelligenceCategory();
        }


        [When(@"User selects the Property Category")]
        public void WhenUserSelectsThePropertyCategory()
        {
            SeleniumHelper.PressPropertyCategory();
        }

        [Then(@"the Property category background should be Blue")]
        public void ThenThePropertyCategoryBackgroundShouldBeBlue()
        {
            SeleniumHelper.PropertyCategory();
        }

        [When(@"User selects the News Category")]
        public void WhenUserSelectsTheNewsCategory()
        {
            SeleniumHelper.pressNewsCategory();
        }

        [Then(@"the News category background should be Purple")]
        public void ThenTheNewsCategoryBackgroundShouldBePurple()
        {
            SeleniumHelper.NewsCategory();
        }

        [When(@"User selects the Lifestyle Category")]
        public void WhenUserSelectsTheLifestyleCategory()
        {
            SeleniumHelper.pressLifestyleCategory();
        }

        [Then(@"the Lifestyle category background should be Orange")]
        public void ThenTheLifestyleCategoryBackgroundShouldBeOrange()
        {
            SeleniumHelper.LifestyleCategory();
        }


        //Mobile IPhone screen size below

        [Given(@"user has visited blog homepage on mobile device")]
        public void GivenUserHasVisitedBlogHomepageOnMobileDevice()
        {
            SeleniumHelper.BlogHomeMobile();
        }

        [When(@"user selects the hamburger menu")]
        public void WhenUserSelectsTheHamburgerMenu()
        {
            SeleniumHelper.PressHamburgerMenu();
        }

        [When(@"selects the intelligence category")]
        public void WhenSelectsTheIntelligenceCategory()
        {
            SeleniumHelper.IntelligenceHamburger();
        }

        [When(@"selects the lifestyle category")]
        public void WhenSelectsTheLifestyleCategory()
        {
            SeleniumHelper.LifestyleHamburger();
        }

        [When(@"selects the news category")]
        public void WhenSelectsTheNewsCategory()
        {
            SeleniumHelper.NewsHamburger();
        }

        [When(@"selects the property category")]
        public void WhenSelectsThePropertyCategory()
        {
            SeleniumHelper.PropertyHamburger();
        }

        [When(@"closes the hamburger menu")]
        public void WhenClosesTheHamburgerMenu()
        {
            SeleniumHelper.CloseHamburger();
        }

        [Then(@"user should see the intelligence sub category menu")]
        public void ThenUserShouldSeeTheIntelligenceSubCategoryMenu()
        {
            SeleniumHelper.IntelligenceSubCat();
        }

        [Then(@"user should see the lifestyle sub category menu")]
        public void ThenUserShouldSeeTheLifestyleSubCategoryMenu()
        {
            SeleniumHelper.LifestyleSubCat();
        }

        [Then(@"user should see the news sub category menu")]
        public void ThenUserShouldSeeTheNewsSubCategoryMenu()
        {
            SeleniumHelper.NewsSubCat();
        }

        [Then(@"user should see the property sub category menu")]
        public void ThenUserShouldSeeThePropertySubCategoryMenu()
        {
            SeleniumHelper.PropertySubCat();
        }

        [Then(@"Intelligence category posts")]
        public void ThenIntelligenceCategoryPosts()
        {
            SeleniumHelper.IntelligencePost();
        }

        [Then(@"lifestyle category posts")]
        public void ThenLifestyleCategoryPosts()
        {
            SeleniumHelper.LifestylePost();
        }

        [Then(@"news category posts")]
        public void ThenNewsCategoryPosts()
        {
            SeleniumHelper.NewsPost();
        }

        [Then(@"property category posts")]
        public void ThenPropertyCategoryPosts()
        {
            SeleniumHelper.PropertyPost();
        }

        //Tablet Portrait below

        [Given(@"user has visited blog homepage on tablet device")]
        public void GivenUserHasVisitedBlogHomepageOnTabletDevice()
        {
            SeleniumHelper.TabletHomeMobile();
        }

        //Large tablet landscape

        [Given(@"user has visited blog homepage on large tablet device")]
        public void GivenUserHasVisitedBlogHomepageOnLargeTabletDevice()
        {
            SeleniumHelper.LargeTabletHomeMobile();
        }

    }
}
