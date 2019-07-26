// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Vermaat.Crm.Specflow.Sample
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Salesflow", Description="\tTests for the lead/opportunity entity to show special dialogs like the qualify l" +
        "ead, process flows and related entities", SourceFile="SalesFlow.feature", SourceLine=0)]
    public partial class SalesflowFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SalesFlow.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Salesflow", "\tTests for the lead/opportunity entity to show special dialogs like the qualify l" +
                    "ead, process flows and related entities", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Lead Qualification", new string[] {
                "API",
                "Chrome",
                "Cleanup"}, SourceLine=4)]
        public virtual void LeadQualification()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Lead Qualification", null, new string[] {
                        "API",
                        "Chrome",
                        "Cleanup"});
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table57 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table57.AddRow(new string[] {
                        "First Name",
                        "Qualify"});
            table57.AddRow(new string[] {
                        "Last Name",
                        "Test"});
            table57.AddRow(new string[] {
                        "Topic",
                        "Qualification Test"});
            table57.AddRow(new string[] {
                        "Company Name",
                        "Qualify Account"});
#line 6
testRunner.Given("a lead named ToQualify with the following values", ((string)(null)), table57, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table58 = new TechTalk.SpecFlow.Table(new string[] {
                        "Account",
                        "Opportunity",
                        "Contact"});
            table58.AddRow(new string[] {
                        "true",
                        "true",
                        "true"});
#line 12
testRunner.When("ToQualify is qualified to a", ((string)(null)), table58, "When ");
#line hidden
            TechTalk.SpecFlow.Table table59 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table59.AddRow(new string[] {
                        "Originating Lead",
                        "ToQualify"});
            table59.AddRow(new string[] {
                        "Account Name",
                        "Qualify Account"});
#line 15
testRunner.Then("an account named QualifyAccount exists with the following values", ((string)(null)), table59, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table60 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table60.AddRow(new string[] {
                        "Originating Lead",
                        "ToQualify"});
            table60.AddRow(new string[] {
                        "Company Name",
                        "QualifyAccount"});
            table60.AddRow(new string[] {
                        "First Name",
                        "Qualify"});
            table60.AddRow(new string[] {
                        "Last Name",
                        "Test"});
#line 19
testRunner.And("a contact exists with the following values", ((string)(null)), table60, "And ");
#line hidden
            TechTalk.SpecFlow.Table table61 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table61.AddRow(new string[] {
                        "Originating Lead",
                        "ToQualify"});
            table61.AddRow(new string[] {
                        "Topic",
                        "Qualification Test"});
#line 25
testRunner.And("an opportunity exists with the following values", ((string)(null)), table61, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Filling Money fields", new string[] {
                "API",
                "Chrome",
                "Cleanup"}, SourceLine=30)]
        public virtual void FillingMoneyFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Filling Money fields", null, new string[] {
                        "API",
                        "Chrome",
                        "Cleanup"});
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table62 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table62.AddRow(new string[] {
                        "Account Name",
                        "TestAccount"});
#line 32
testRunner.Given("an account named TestAccount with the following values", ((string)(null)), table62, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table63 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table63.AddRow(new string[] {
                        "Topic",
                        "Test Opp Money"});
            table63.AddRow(new string[] {
                        "Budget Amount",
                        "12345"});
#line 35
testRunner.When("a related opportunity from TestAccount named TestOpp is created with the followin" +
                    "g values", ((string)(null)), table63, "When ");
#line hidden
            TechTalk.SpecFlow.Table table64 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table64.AddRow(new string[] {
                        "Topic",
                        "Test Opp Money"});
            table64.AddRow(new string[] {
                        "Budget Amount",
                        "12345"});
            table64.AddRow(new string[] {
                        "Account",
                        "TestAccount"});
#line 39
testRunner.Then("TestOpp has the following values", ((string)(null)), table64, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Convert Quote to Sales Order", new string[] {
                "API",
                "Chrome",
                "Cleanup"}, SourceLine=45)]
        public virtual void ConvertQuoteToSalesOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Convert Quote to Sales Order", null, new string[] {
                        "API",
                        "Chrome",
                        "Cleanup"});
#line 46
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table65 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table65.AddRow(new string[] {
                        "Account Name",
                        "QuoteTesting"});
#line 47
testRunner.Given("an account named QuoteTesting with the following values", ((string)(null)), table65, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table66 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table66.AddRow(new string[] {
                        "Name",
                        "AT Quote"});
            table66.AddRow(new string[] {
                        "Price List",
                        "Automated Testing PL"});
            table66.AddRow(new string[] {
                        "Potential Customer",
                        "QuoteTesting"});
#line 50
testRunner.And("a quote named TestQuote with the following values", ((string)(null)), table66, "And ");
#line 56
testRunner.When("TestQuote is activated and converted to a sales order named TestOrder", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table67 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table67.AddRow(new string[] {
                        "Name",
                        "AT Quote"});
            table67.AddRow(new string[] {
                        "Price List",
                        "Automated Testing PL"});
            table67.AddRow(new string[] {
                        "Customer",
                        "QuoteTesting"});
            table67.AddRow(new string[] {
                        "Quote",
                        "TestQuote"});
#line 57
testRunner.Then("TestOrder has the following values", ((string)(null)), table67, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Revise a quote", new string[] {
                "API",
                "Chrome",
                "Cleanup"}, SourceLine=64)]
        public virtual void ReviseAQuote()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Revise a quote", null, new string[] {
                        "API",
                        "Chrome",
                        "Cleanup"});
#line 65
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table68 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table68.AddRow(new string[] {
                        "Account Name",
                        "QuoteTesting"});
#line 66
testRunner.Given("an account named QuoteTesting with the following values", ((string)(null)), table68, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table69 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table69.AddRow(new string[] {
                        "Name",
                        "AT Quote to Revise"});
            table69.AddRow(new string[] {
                        "Price List",
                        "Automated Testing PL"});
            table69.AddRow(new string[] {
                        "Potential Customer",
                        "QuoteTesting"});
#line 69
testRunner.And("a quote named TestQuote with the following values", ((string)(null)), table69, "And ");
#line 74
testRunner.When("the quote TestQuote is activated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
testRunner.And("TestQuote is revised and its revised quote is named RevisiedQuote", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table70 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table70.AddRow(new string[] {
                        "Name",
                        "AT Quote to Revise"});
            table70.AddRow(new string[] {
                        "Price List",
                        "Automated Testing PL"});
            table70.AddRow(new string[] {
                        "Potential Customer",
                        "QuoteTesting"});
#line 76
testRunner.Then("RevisiedQuote has the following values", ((string)(null)), table70, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
