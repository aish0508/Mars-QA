using Aspose.Cells.Drawing;
using Mars_QA.Pages;
using Mars_QA.Utilis;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars_QA.StepsDefinition
{
    [Binding]
    public class StepDefinitions : CommonDriver
    {
        Login loginPageObj;
        Profile profileObj;
        Edit editObj;
        Delete deleteObj;
        public StepDefinitions()
        {
            loginPageObj = new Login();
            profileObj = new Profile();
            editObj = new Edit();
            deleteObj = new Delete();
        }

        [Given(@"I Logged into a portal")]
        public void GivenILoggedIntoAPortal()
        {
            // Open Chrome Browser
            Initialize();
            // Login page object initialization and definition
            loginPageObj.LoginActions();
        }

        [When(@"I Clicked On Language Tab and Add Language Including '([^']*)' , '([^']*)' Afterthat Click on Skill Tab to add skill including '([^']*)' , '([^']*)'")]
        public void WhenIClickedOnLanguageTabAndAddLanguageIncludingAfterthatClickOnSkillTabToAddSkillIncluding(string LanguageName, string LanguageType, string SkillName, string SkillType)
        {
            profileObj.AddLanguageAndSkill(LanguageName, LanguageType, SkillName, SkillType);
            
        }
        [Then(@"Verify by adding duplicate Language and see record of language and skill including '([^']*)','([^']*)' ,'([^']*)','([^']*)' Created in the profile")]
        public void ThenVerifyByAddingDuplicateLanguageAndSeeRecordOfLanguageAndSkillIncludingCreatedInTheProfile(string LanguageName, string LanguageType, string SkillName, string SkillType)
        {
            string ActualMessage;
            string ActualSkillMessage;

            ActualMessage = profileObj.AssertByAddingDuplicateLanguage(LanguageName, LanguageType, SkillName, SkillType);
            ActualSkillMessage = profileObj.AssertByAddingDuplicateLanguage(LanguageName, LanguageType, SkillName, SkillType);
            string ExpectedMessage = "This language is already exist in your language list";
            Assert.That(ActualMessage.Equals(ExpectedMessage), "The language is added to the language list");
            string ExpectedMessage1 = "This skill is already exist in your list";
            Assert.That(ActualSkillMessage.Equals(ExpectedMessage1), "The skill is added to the skill list");
            

        }

        [Then(@"Edit the already added Language and Skill Field including '([^']*)' ,'([^']*)','([^']*)' ,'([^']*)'")]
        public void ThenEditTheAlreadyAddedLanguageAndSkillFieldIncluding(string LanguageName, string LanguageType, string SkillName, string SkillType)
        {
            editObj.EditLangandSkill(LanguageName, LanguageType, SkillName, SkillType);
            
        }
        [Then(@"And I attempt to edit with invalid language '([^']*)' and invalid skill '([^']*)'")]
        public void ThenAndIAttemptToEditWithInvalidLanguageAndInvalidSkill(string InvalidLanguageName, string InvalidSkillName)
        {
            string ActualMessage1;
            string ActualMessage2;
            ActualMessage1 = editObj.EditLangAndSkillWithInvalid(InvalidLanguageName, InvalidSkillName);
            ActualMessage2 = editObj.EditLangAndSkillWithInvalid(InvalidLanguageName, InvalidSkillName);
            string ExpectedMessage = "Please add Valid language or Valid Skill in the language list";
            Assert.That(ActualMessage1.Equals(ExpectedMessage), "The Language is added to the language List");
            Assert.That(ActualMessage2.Equals(ExpectedMessage), "The Skill is added to the Skill List");
            

        }

        [Then(@"I delete the selected language and skill")]
        public void ThenIDeleteTheSelectedLanguageAndSkill()
        {
            deleteObj.DeleteOption();
            
        }

        //[AfterStep]
        //public void AfterStep()
        //{
        //    TearDown();
        //}
        
    





    }
}
