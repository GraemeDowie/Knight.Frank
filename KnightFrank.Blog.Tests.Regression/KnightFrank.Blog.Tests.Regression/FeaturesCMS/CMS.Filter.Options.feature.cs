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
    [NUnit.Framework.DescriptionAttribute("CMS Filter Options")]
    public partial class CMSFilterOptionsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CMS.Filter.Options.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CMS Filter Options", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Distance Filter has correct options")]
        [NUnit.Framework.TestCaseAttribute("Distance", null)]
        [NUnit.Framework.TestCaseAttribute("This Area Only", null)]
        [NUnit.Framework.TestCaseAttribute("5 miles", null)]
        [NUnit.Framework.TestCaseAttribute("10 miles", null)]
        [NUnit.Framework.TestCaseAttribute("11 miles", null)]
        [NUnit.Framework.TestCaseAttribute("12 miles", null)]
        [NUnit.Framework.TestCaseAttribute("13 miles", null)]
        [NUnit.Framework.TestCaseAttribute("14 miles", null)]
        [NUnit.Framework.TestCaseAttribute("15 miles", null)]
        public virtual void DistanceFilterHasCorrectOptions(string distanceValue, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Distance Filter has correct options", exampleTags);
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("user has visited knight frank homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.When("user opens the distance filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
 testRunner.Then(string.Format("user should see {0} distance values", distanceValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Property type filter has correct options")]
        [NUnit.Framework.TestCaseAttribute("Property Type", null)]
        [NUnit.Framework.TestCaseAttribute("House", null)]
        [NUnit.Framework.TestCaseAttribute("Flat", null)]
        [NUnit.Framework.TestCaseAttribute("Farms & land", null)]
        [NUnit.Framework.TestCaseAttribute("New homes", null)]
        [NUnit.Framework.TestCaseAttribute("Development", null)]
        [NUnit.Framework.TestCaseAttribute("Other residential", null)]
        public virtual void PropertyTypeFilterHasCorrectOptions(string propertyValue, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Property type filter has correct options", exampleTags);
#line 22
this.ScenarioSetup(scenarioInfo);
#line 23
 testRunner.Given("user has visited the knight frank homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
 testRunner.When("user opens the property types filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then(string.Format("user should see {0} property values", propertyValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Bedroom Filter has correct options")]
        [NUnit.Framework.TestCaseAttribute("Bedrooms", null)]
        [NUnit.Framework.TestCaseAttribute("Studio", null)]
        [NUnit.Framework.TestCaseAttribute("1+", null)]
        [NUnit.Framework.TestCaseAttribute("2+", null)]
        [NUnit.Framework.TestCaseAttribute("3+", null)]
        [NUnit.Framework.TestCaseAttribute("4+", null)]
        [NUnit.Framework.TestCaseAttribute("5+", null)]
        public virtual void BedroomFilterHasCorrectOptions(string bedroomValue, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bedroom Filter has correct options", exampleTags);
#line 38
this.ScenarioSetup(scenarioInfo);
#line 39
 testRunner.Given("user has visited the knight frank homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
 testRunner.When("user opens the bedroom filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then(string.Format("user should see {0} bedroom values", bedroomValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Commercial Property types have correct options")]
        [NUnit.Framework.TestCaseAttribute("Property Types", null)]
        [NUnit.Framework.TestCaseAttribute("Offices", null)]
        [NUnit.Framework.TestCaseAttribute("Serviced Offices", null)]
        [NUnit.Framework.TestCaseAttribute("Development", null)]
        [NUnit.Framework.TestCaseAttribute("Industrial", null)]
        [NUnit.Framework.TestCaseAttribute("Commercial land", null)]
        [NUnit.Framework.TestCaseAttribute("Hotels & leisure", null)]
        [NUnit.Framework.TestCaseAttribute("Retail", null)]
        [NUnit.Framework.TestCaseAttribute("Other commercial", null)]
        public virtual void CommercialPropertyTypesHaveCorrectOptions(string comPropertyTypes, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Commercial Property types have correct options", exampleTags);
#line 53
this.ScenarioSetup(scenarioInfo);
#line 54
 testRunner.Given("user has visited the knight frank homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 55
 testRunner.When("user opens commercial property type filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.Then(string.Format("user should see commercial {0} property types", comPropertyTypes), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Commercial Floor area have correct options")]
        [NUnit.Framework.TestCaseAttribute("Floor area", null)]
        [NUnit.Framework.TestCaseAttribute("0 - 100 sqft", null)]
        [NUnit.Framework.TestCaseAttribute("101 - 500 sqft", null)]
        [NUnit.Framework.TestCaseAttribute("501 - 1000 sqft", null)]
        [NUnit.Framework.TestCaseAttribute("1,001 - 5,000 sqft", null)]
        [NUnit.Framework.TestCaseAttribute("5,001 - 10,000 sqft", null)]
        [NUnit.Framework.TestCaseAttribute("10,001 - 50,000 sqft", null)]
        public virtual void CommercialFloorAreaHaveCorrectOptions(string comFloorArea, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Commercial Floor area have correct options", exampleTags);
#line 71
this.ScenarioSetup(scenarioInfo);
#line 72
 testRunner.Given("user has visited the knight frank homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 73
 testRunner.When("user opens commercial Floor area filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.Then(string.Format("user should see commercial {0} floor area", comFloorArea), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
