﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Mars_QA.SpecFlow
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Feature")]
    public partial class FeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "LanguageFeature.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SpecFlow", "Feature", "As a User Create a Profile then add ,edit and delete languages so that recuriter " +
                    "see your languages in the dashboard", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("1. Delete all the language from language list")]
        [NUnit.Framework.CategoryAttribute("Language")]
        public void _1_DeleteAllTheLanguageFromLanguageList()
        {
            string[] tagsOfScenario = new string[] {
                    "Language"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1. Delete all the language from language list", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 8
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 9
  testRunner.Given("I Logged into a portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
  testRunner.Then("delete all the languages from the language list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("2. Add Languages in a profile")]
        [NUnit.Framework.TestCaseAttribute("Hindi", "Fluent", null)]
        [NUnit.Framework.TestCaseAttribute("Spanish", "Basic", null)]
        [NUnit.Framework.TestCaseAttribute("English", "Fluent", null)]
        public void _2_AddLanguagesInAProfile(string languageName, string languageType, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("LanguageName", languageName);
            argumentsOfScenario.Add("LanguageType", languageType);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2. Add Languages in a profile", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 12
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 13
 testRunner.Given("I Logged into a portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 14
 testRunner.Then(string.Format("I Clicked On Language Tab and Add Language Including \'{0}\' , \'{1}\'", languageName, languageType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("3. Verify Empty Scenario with language textbox as empty")]
        [NUnit.Framework.TestCaseAttribute("", "Fluent", null)]
        [NUnit.Framework.TestCaseAttribute("", "", null)]
        public void _3_VerifyEmptyScenarioWithLanguageTextboxAsEmpty(string languageName, string languageType, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("LanguageName", languageName);
            argumentsOfScenario.Add("LanguageType", languageType);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("3. Verify Empty Scenario with language textbox as empty", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 23
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 24
testRunner.Given("I Logged into a portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 25
testRunner.When(string.Format("User leaves language textbox including  \'{0}\' ,\'{1}\' as empty", languageName, languageType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("4.Verify by adding existing Language  in the  profile")]
        [NUnit.Framework.TestCaseAttribute("English", "Fluent", "API Testing", "Expert", "This language is already exist in your language list.", null)]
        public void _4_VerifyByAddingExistingLanguageInTheProfile(string languageName, string languageType, string skillName, string skillType, string langMessage, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("LanguageName", languageName);
            argumentsOfScenario.Add("LanguageType", languageType);
            argumentsOfScenario.Add("SkillName", skillName);
            argumentsOfScenario.Add("SkillType", skillType);
            argumentsOfScenario.Add("LangMessage", langMessage);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("4.Verify by adding existing Language  in the  profile", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 36
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 37
testRunner.Given("I Logged into a portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 38
testRunner.When(string.Format("user adding by existing language including \'{0}\',\'{1}\'", languageName, languageType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 39
testRunner.Then(string.Format("DuplicateMessage \'{0}\' should be display", langMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("5. Edit the already added Language field with Valid Inputs")]
        [NUnit.Framework.TestCaseAttribute("French", "Basic", "SQL", "Expert", "French has been updated to your languages", null)]
        public void _5_EditTheAlreadyAddedLanguageFieldWithValidInputs(string languageName, string languageType, string skillName, string skillType, string messageWithValidLang, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("LanguageName", languageName);
            argumentsOfScenario.Add("LanguageType", languageType);
            argumentsOfScenario.Add("SkillName", skillName);
            argumentsOfScenario.Add("SkillType", skillType);
            argumentsOfScenario.Add("MessageWithValidLang", messageWithValidLang);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("5. Edit the already added Language field with Valid Inputs", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 45
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 46
  testRunner.Given("I Logged into a portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 47
  testRunner.When(string.Format("Edit the already added Language  Field including \'{0}\' ,\'{1}\'", languageName, languageType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
  testRunner.Then(string.Format("Edit_AlertMessage \'{0}\' should be display", messageWithValidLang), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("6.Edit the already added language with Invalid Input")]
        [NUnit.Framework.TestCaseAttribute("D344@rfgd$dtereere+=reer3", "r5676@e", "D344@rfgd$dtereerereer35464533 has been updated to your languages", null)]
        public void _6_EditTheAlreadyAddedLanguageWithInvalidInput(string invalidLanguageName, string invalidSkillName, string messageWithInvalidLang, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("InvalidLanguageName", invalidLanguageName);
            argumentsOfScenario.Add("InvalidSkillName", invalidSkillName);
            argumentsOfScenario.Add("MessageWithInvalidLang", messageWithInvalidLang);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("6.Edit the already added language with Invalid Input", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 56
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 57
 testRunner.Given("I Logged into a portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 58
    testRunner.When(string.Format("Edit the added language with invalid inputs including \'{0}\'", invalidLanguageName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
 testRunner.Then(string.Format("EditMessage \'{0}\'  should be display", messageWithInvalidLang), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion