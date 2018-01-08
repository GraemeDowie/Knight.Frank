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
    public class AdminSitesAreWorkingAndAbleToLogInSteps
    {
        [Given(@"user has visited (.*) adminCMS")]
        public void GivenUserHasVisitedAdminCMS(string adminCMS)
        {
            SeleniumHelper.WebDriver.Url = adminCMS;
            SeleniumHelper.WebDriver.Manage().Window.Maximize();
        }
        
        [When(@"user login with valid credentials")]
        public void WhenUserLoginWithValidCredentials(Table table)
        {
            var LogIn = table.CreateInstance<adminCred>();

            var enterUser = SeleniumHelper.WebDriver.FindElement(By.Id("ContentPlaceHolder2_Login1_UserName"));
            enterUser.SendKeys(LogIn.userName);

            var enterPass = SeleniumHelper.WebDriver.FindElement(By.Id("ContentPlaceHolder2_Login1_Password"));
            enterPass.SendKeys(LogIn.Password);

            var logInButton = SeleniumHelper.WebDriver.FindElement(By.Id("ContentPlaceHolder2_Login1_LoginButton"));
            logInButton.Click();
        }
        
        [Then(@"user should see log in details and CMS dashboard")]
        public void ThenUserShouldSeeLogInDetailsAndCMSDashboard()
        {
            WebDriverWait waitForDash = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForDash.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".dashboard-title")));

            var recentPage = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".dashboard-recent"));
            Assert.Contains("Your recent pages", recentPage.Text);
        }
    }
}
