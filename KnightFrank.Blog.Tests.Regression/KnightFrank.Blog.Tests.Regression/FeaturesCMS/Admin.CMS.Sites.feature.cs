﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace KnightFrank.Blog.Tests.Regression.FeaturesCMS
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Admin Sites are working and able to log in")]
    public partial class AdminSitesAreWorkingAndAbleToLogInFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Admin.CMS.Sites.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Admin Sites are working and able to log in", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User has visited AdminCMS and login With valid credentials")]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.co.uk/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.com/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.com.ro/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.cz/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.it/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.ae/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.ie/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.ru/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.qa/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.fr/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.de/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.es/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.com.pl/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.be/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.co.ke/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.mw/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.com.ng/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.rw/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.co.za/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.co.tz/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.ug/admin/login.aspx", null)]
        [NUnit.Framework.TestCaseAttribute("http://beta.admincms.knightfrank.co.zw/admin/login.aspx", null)]
        public virtual void UserHasVisitedAdminCMSAndLoginWithValidCredentials(string adminCMS, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User has visited AdminCMS and login With valid credentials", exampleTags);
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given(string.Format("user has visited {0} adminCMS", adminCMS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "userName",
                        "Password"});
            table1.AddRow(new string[] {
                        "digital@knightfrank.com",
                        "Pa55word"});
#line 7
 testRunner.When("user login with valid credentials", ((string)(null)), table1, "When ");
#line 10
 testRunner.Then("user should see log in details and CMS dashboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
