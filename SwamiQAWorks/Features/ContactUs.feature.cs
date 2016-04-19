﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SwamiQAWorks.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ContactUs")]
    public partial class ContactUsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ContactUs.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ContactUs", "\tAs an end user \r\n\tI want a contact us page \r\n\tSo that I can find out more about " +
                    "QAWorks exciting services", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void FeatureBackground()
        {
#line 7
#line 8
testRunner.Given("I am on the Contact Us Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Valid Submission")]
        [NUnit.Framework.CategoryAttribute("contactUs")]
        public virtual void ValidSubmission()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Valid Submission", new string[] {
                        "contactUs"});
#line 11
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 12
 testRunner.When("I send a message \"please contact me I want to find out more \" as \"j.Bloggs6\"and w" +
                    "ith the email address \"j.Blogge@qaworks.com\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("the message should be sent successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Invalid Submission")]
        [NUnit.Framework.TestCaseAttribute("Joe", "j.Bloggs@qaworks.com", "", "", "", "Please type your message", new string[0])]
        [NUnit.Framework.TestCaseAttribute("", "j.Bloggs@qaworks.com", "message", "Your name is required", "", "", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Joe", "", "message", "", "An Email address is required", "", new string[0])]
        [NUnit.Framework.TestCaseAttribute("", "", "", "Your name is required", "An Email address is required", "Please type your message", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Joe", "J.Blogss.email", "message", "", "Invalid Email Address", "", new string[0])]
        public virtual void InvalidSubmission(string user, string email_Address, string message, string name_Validation_Message, string email_Validation_Message, string message_Validation, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Invalid Submission", exampleTags);
#line 15
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 16
 testRunner.When(string.Format("as \"{0}\" with\"{1}\" I Attempt to send \"{2}\" without filling in all the required fi" +
                        "elds", user, email_Address, message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.Then(string.Format("the validation message should be \"{0}\",\"{1}\" and \"{2}\"", name_Validation_Message, email_Validation_Message, message_Validation), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
