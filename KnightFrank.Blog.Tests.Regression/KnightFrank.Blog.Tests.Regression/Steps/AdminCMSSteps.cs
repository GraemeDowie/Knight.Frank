using KnightFrank.Blog.Tests.Regression.Model;
using KnightFrank.Tests.Regression;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using Xunit;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace KnightFrank.Blog.Tests.Regression.Steps
{
    [Binding]
    public class AdminCMSSteps
    {
        public static IWebDriver WebDriver = SeleniumHelper.WebDriver;
        [Given(@"administrator has logged into admin with Valid Credentials")]
        public void GivenAdministratorHasLoggedIntoAdminWithValidCredentials(Table table)
        {

            WebDriver.Url = "http://beta.admincms.knightfrank.co.uk/admin";
            WebDriver.Manage().Window.Maximize();

            var adminUser = table.CreateInstance<UserDetails>();

            var logInName = WebDriver.FindElement(By.Id("ContentPlaceHolder2_Login1_UserName"));
            logInName.SendKeys(adminUser.UsernameBetaCMS);

            var logInPassword = WebDriver.FindElement(By.Id("ContentPlaceHolder2_Login1_Password"));
            logInPassword.SendKeys(adminUser.PasswordBetaCMS);

            SeleniumHelper.BetaAdminCMSLoginButton();

            var confirmLogIn = WebDriver.FindElement(By.ClassName("dashboard-title")).Text;
            Assert.Equal("Knight Frank UK CMS Dashboard", confirmLogIn);
        }

        [When(@"administrator selects users from the settings drop down")]
        public void WhenAdministratorSelectsUsersFromTheSettingsDropDown()
        {
            var settingsDrop = WebDriver.FindElement(By.XPath("//*[@id='headingSettings']/h4/a"));
            settingsDrop.Click();

            WebDriverWait waitForMenu = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
            waitForMenu.Until(ExpectedConditions.ElementIsVisible(By.Id("collapseSettings")));

            var usersMenu = WebDriver.FindElement(By.XPath("//*[@id='Navigation1_liUsers']/a"));
            usersMenu.Click();
        }
        
        [When(@"User selects new user")]
        public void WhenUserSelectsNewUser()
        {
            WebDriverWait waitForDash = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
            waitForDash.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".dashboard-grid")));

            var newUser = WebDriver.FindElement(By.CssSelector(".explorer-actions"));
            newUser.Click();
        }
        
        [When(@"administrator enters new credentials")]
        public void WhenAdministratorEntersNewCredentials(Table table)
        {

            var newUserDetails = table.CreateInstance<NewUserDetails>();

            var newEmail = WebDriver.FindElement(By.Id("ContentPlaceHolder2_txtUserName"));
            newEmail.SendKeys(newUserDetails.newUserCMSEmail);

            var newPassword = WebDriver.FindElement(By.Id("ContentPlaceHolder2_txtPassword"));
            newPassword.SendKeys(newUserDetails.newUserCMSPassword);

            var confirmNewPassword = WebDriver.FindElement(By.Id("ContentPlaceHolder2_txtConfirmPassword"));
            confirmNewPassword.SendKeys(newUserDetails.newUserCMSConfirmPassword);
        }
        
        [When(@"then saves this user account")]
        public void WhenThenSavesThisUserAccount()
        {
            var saveUserDetails = WebDriver.FindElement(By.Id("ContentPlaceHolder2_btnOK"));
            saveUserDetails.Click();
        }
        
        [Then(@"new user should be visible as an author on user list page")]
        public void ThenNewUserShouldBeVisibleAsAnAuthorOnUserListPage()
        {
            WebDriverWait waitForDash = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
            waitForDash.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".dashboard-grid")));

            var userCreated = WebDriver.FindElement(By.CssSelector(".dashboard-grid")).Text;
            Assert.Contains("digital@knightfrank.com", userCreated);
        }
    }
}
