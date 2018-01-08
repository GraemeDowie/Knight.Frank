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
    public class ContactUsAtoZSteps
    {
        [Given(@"user has visited Contact Us A to Z page on desktop")]
        public void GivenUserHasVisitedContactUsAToZPageOnDesktop()
        {
            SeleniumHelper.SetUpContactUsAtoZ();
        }
        
        [Then(@"user should see the page title information")]
        public void ThenUserShouldSeeThePageTitleInformation(Table table)
        {
            var pageTitle = table.CreateInstance<PageTitle>();

            var pagePara = table.CreateInstance<PagePara>();

            var confirmTitle = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".contact-us-content h1"));
            Assert.Equal(pageTitle.pageHead, confirmTitle.Text);

            var confirmPagePara = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".contact-us-content p"));
            Assert.Equal(pagePara.pagePara, confirmPagePara.Text);
        }

        [Then(@"user should see the letters of the alphabet to select an office")]
        public void ThenUserShouldSeeTheLettersOfTheAlphabetToSelectAnOffice(Table table)
        {
            var alphabet = table.CreateInstance<AlphaLenghth>();

            var AlphabetLength = SeleniumHelper.WebDriver.FindElements(By.CssSelector(".slick-slide"));
            Assert.Equal(alphabet.alphaLength, AlphabetLength.Count.ToString());
        }
        
    }
}
