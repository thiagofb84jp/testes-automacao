﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.17929
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace FundTransfer.specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Customer Transfer\'s Fund")]
    public partial class CustomerTransferSFundFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FundTransfer.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Customer Transfer\'s Fund", "     As a customer,\r\n     I want to transfer funds\r\n     so that I can send money" +
                    " to my friends and family", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        [NUnit.Framework.DescriptionAttribute("Valid Payee")]
        public virtual void ValidPayee()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Valid Payee", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
       testRunner.Given("the user is on Fund Transfer Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
       testRunner.When("he enters \"Jim\" as payee name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
       testRunner.And("he enters \"100\" as amount", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
       testRunner.And("he Submits request for Fund Transfer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
       testRunner.Then("ensure the fund transfer is complete with \"$100 transferred successfully to Jim!!" +
                    "\" message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Invalid Payee")]
        public virtual void InvalidPayee()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Invalid Payee", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
       testRunner.Given("the user is on Fund Transfer Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
       testRunner.When("he enters \"Unmesh\" as payee name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
       testRunner.And("he enters \"100\" as amount", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
       testRunner.And("he Submits request for Fund Transfer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
       testRunner.Then("ensure a transaction failure message \"Transfer failed!! \'Unmesh\' is not registere" +
                    "d in your List of Payees\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Account is overdrawn past the overdraft limit")]
        public virtual void AccountIsOverdrawnPastTheOverdraftLimit()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account is overdrawn past the overdraft limit", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
       testRunner.Given("the user is on Fund Transfer Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
       testRunner.When("he enters \"Tim\" as payee name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
       testRunner.And("he enters \"1000000\" as amount", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
       testRunner.And("he Submits request for Fund Transfer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
       testRunner.Then("ensure a transaction failure message \"Transfer failed!! account cannot be overdra" +
                    "wn\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
