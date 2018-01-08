using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace KnightFrank.Blog.Tests.Regression.Steps
{
    [Binding]
    public class ClosedBugsSteps
    {
        [Given(@"user has visited the commercial leeds office page")]
        public void GivenUserHasVisitedTheCommercialLeedsOfficePage()
        {
            SeleniumHelper.WebDriver.Url = "http://beta.knightfrank.co.uk/contact/a-new-template/commercial-property-leeds";

            SeleniumHelper.WebDriver.Manage().Window.Maximize();
        }
        
        [Then(@"user should see an email button labelled Contact Office")]
        public void ThenUserShouldSeeAnEmailButtonLabelledContactOffice(Table table)
        {
            var emailButton = table.CreateInstance<ContactEmailButton>();

            var validateButtonText = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".contact-email"));
            Assert.Equal(emailButton.contactEmailButton, validateButtonText.Text);
        }

        [Given(@"User has visited Knight Frank China Domain")]
        public void GivenUserHasVisitedKnightFrankChinaDomain(Table table)
        {
            var chinaURL = table.CreateInstance<KFChina>();

            SeleniumHelper.WebDriver.Url = chinaURL.kfChina;
            SeleniumHelper.WebDriver.Manage().Window.Maximize();
        }

        [When(@"user clicks on the people office tab")]
        public void WhenUserClicksOnThePeopleOfficeTab()
        {
            SeleniumHelper.officeTabClick();
        }

        [When(@"searches for China")]
        public void WhenSearchesForChina(Table table)
        {
            var officeSearchTerm = table.CreateInstance<OfficeSearch>();

            WebDriverWait waitForOfficeSearch = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForOfficeSearch.Until(ExpectedConditions.ElementIsVisible(By.Id("txtOfficeSearchBox")));

            var inputOfficeSearch = SeleniumHelper.WebDriver.FindElement(By.Id("txtOfficeSearchBox"));
            inputOfficeSearch.SendKeys(officeSearchTerm.officeSearch);

            WebDriverWait waitForAutoSuggest = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForAutoSuggest.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".pac-container.pac-logo")));


            WebDriverWait waitForChina = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForChina.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".pac-container.pac-logo > div:nth-child(1)")));

            var clickChina = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".pac-container.pac-logo > div:nth-child(1)"));
            clickChina.Click();
        }

        [Then(@"user should see a list of office locations in China (.*)")]
        public void ThenUserShouldSeeAListOfOfficeLocationsInChina(string chinaOffice)
        {
            SeleniumHelper.WaitForMap();

            string url = SeleniumHelper.WebDriver.Url;
            Assert.Equal("http://beta.knightfrank.com.cn/en/contact#/offices/CN/China/35.86166000000001,104.19539699999996", url);

            var officeName = SeleniumHelper.WebDriver.FindElement(By.CssSelector("#contact-us"));
            Assert.Contains(chinaOffice, officeName.Text);
        }

        [Given(@"user is on the Knight Frank research page")]
        public void GivenUserIsOnTheKnightFrankResearchPage(Table table)
        {
            var researchHome = table.CreateInstance<ResearchURL>();

            SeleniumHelper.WebDriver.Url = researchHome.researchURL;
            SeleniumHelper.WebDriver.Manage().Window.Maximize();
        }

        [When(@"user selects the people office tab and searches for an office")]
        public void WhenUserSelectsThePeopleOfficeTabAndSearchesForAnOffice(Table table)
        {
            SeleniumHelper.officeTabClick();

            var officeSearch = table.CreateInstance<OfficeSearchLocation>();

            WebDriverWait waitForOfficeSearch = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForOfficeSearch.Until(ExpectedConditions.ElementIsVisible(By.Id("txtOfficeSearchBox")));

            var enterOfficeName = SeleniumHelper.WebDriver.FindElement(By.Id("txtOfficeSearchBox"));
            enterOfficeName.SendKeys(officeSearch.officeSearchLocation);

            WebDriverWait waitForAutoSuggest = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForAutoSuggest.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("..pac-container")));

            WebDriverWait waitForSoho = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForSoho.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("iv.pac-container.pac-logo > div:nth-child(1)")));

            var clickSoho = SeleniumHelper.WebDriver.FindElement(By.CssSelector("iv.pac-container.pac-logo > div:nth-child(1)"));
            clickSoho.Click();
        }

        [Then(@"user should see a returned office search with the search location")]
        public void ThenUserShouldSeeAReturnedOfficeSearchWithTheSearchLocation(Table table)
        {
            SeleniumHelper.WaitForMap();

            var sohoResult = table.CreateInstance<ReturnedResult>();

            var officeNameReturned = SeleniumHelper.WebDriver.FindElement(By.CssSelector("#contact-us"));
            Assert.Contains(sohoResult.returnedResult, officeNameReturned.Text);
        }

        [Given(@"user has visited a Knight Frank Team page on \.com")]
        public void GivenUserHasVisitedAKnightFrankTeamPageOn_Com(Table table)
        {
            var pageTeam = table.CreateInstance<TeamPage>();

            SeleniumHelper.WebDriver.Url = pageTeam.teamPage;
            SeleniumHelper.WebDriver.Manage().Window.Maximize();
        }

        [Given(@"selects to view a colleague profile")]
        public void GivenSelectsToViewAColleagueProfile()
        {
            var profileName = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".slick-current > article > div > div > h3")).Text;

            Assert.Equal("Andrew Sim", profileName);

            var clickProfileButton = SeleniumHelper.WebDriver.FindElement(By.Id("cpMain_ucc2_ctl00_rptKeyContacts_hlBiog_0"));
            clickProfileButton.Click();
        }

        [Then(@"user should be directed to the correct colleague page")]
        public void ThenUserShouldBeDirectedToTheCorrectColleaguePage(Table table)
        {
            var URLProfile = SeleniumHelper.WebDriver.Url;

            var profileUrl = table.CreateInstance<ColleagueURL>();

            Assert.Equal(URLProfile, profileUrl.colleagueURL);

            var nameOfContact = table.CreateInstance<ContactName>();

            var contactDetail = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".contact-detail h3"));
            Assert.Equal(nameOfContact.contactName, contactDetail.Text.Replace("\r\n", " "));
        }

    }
}
