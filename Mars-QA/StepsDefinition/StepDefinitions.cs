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
            //Open Chrome Browser
            dr = new ChromeDriver();
            //Maximize the browser
            dr.Manage().Window.Maximize();

            // Login page object initialization and definition
            loginPageObj.LoginActions();
        }

        [When(@"I Clicked On Language Tab and Add Language Including '([^']*)' , '([^']*)' Afterthat Click on Skill Tab to add skill including '([^']*)' , '([^']*)'")]
        public void WhenIClickedOnLanguageTabAndAddLanguageIncludingAfterthatClickOnSkillTabToAddSkillIncluding(string LanguageName, string LanguageType, string SkillName, string SkillType)
        {
            profileObj.AddLanguageAndSkill(LanguageName, LanguageType, SkillName, SkillType);
        }
        [Then(@"Verify by adding duplicate Language and see record of language and skill including '([^']*)','([^']*)' ,'([^']*)' Created in the profile")]
        public void ThenVerifyByAddingDuplicateLanguageAndSeeRecordOfLanguageAndSkillIncludingCreatedInTheProfile(string LanguageName, string LanguageType, string message)
        {
            profileObj.AssertByAddingDuplicateLanguage(LanguageName, LanguageType, message);
            Assert.That(message, Is.EqualTo("Punjabi has been added in your language list"));
        }

        [Then(@"Edit the already added Language and Skill Field including '([^']*)' ,'([^']*)','([^']*)' ,'([^']*)'")]
        public void ThenEditTheAlreadyAddedLanguageAndSkillFieldIncluding(string LanguageName, string LanguageType, string SkillName, string SkillType)
        {
            editObj.EditLangandSkill(LanguageName, LanguageType, SkillName, SkillType);
        }
        [Then(@"And I attempt to edit with invalid language '([^']*)' and invalid skill '([^']*)' ,'([^']*)','([^']*)'")]
        public void WhenAndIAttemptToEditWithInvalidLanguageAndInvalidSkill(string InvalidLanguageName, string InvalidSkillName, string message, string message1)
        {
            editObj.EditLangAndSkillWithInvalid(InvalidLanguageName, InvalidSkillName, message, message1);
            Assert.That(message, Is.EqualTo($"Invalid language {InvalidLanguageName}"));
            Assert.That(message1, Is.EqualTo($"Invalid Skill {InvalidSkillName}"));

        }
                    
        [Then(@"I delete the selected language and skill")]
        public void ThenIDeleteTheSelectedLanguageAndSkill()
        {
            deleteObj.DeleteOption();
        }

       

       

    }
}
