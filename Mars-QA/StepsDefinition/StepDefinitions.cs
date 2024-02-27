using Aspose.Cells.Drawing;
using Mars_QA.Pages;
using Mars_QA.Utilis;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
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

        public string ActualSkillMessage { get; private set; }

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

        [Then(@"I Clicked On Language Tab and Add Language Including '([^']*)' , '([^']*)' Afterthat Click on Skill Tab to add skill including '([^']*)' , '([^']*)'")]
        public void ThenIClickedOnLanguageTabAndAddLanguageIncludingAfterthatClickOnSkillTabToAddSkillIncluding(string LanguageName, string LanguageType, string SkillName, string SkillType)
        {
            profileObj.AddLanguageAndSkill(LanguageName, LanguageType, SkillName, SkillType);
            

        }
        
        [When(@"User leaves language textbox including  '([^']*)' ,'([^']*)' as empty and skill textbox including '([^']*)','([^']*)' as empty")]
        public void WhenUserLeavesLanguageTextboxIncludingAsEmptyAndSkillTextboxIncludingAsEmpty(string LanguageName, string LanguageType, string SkillName, string SkillType)
        {
            string ActualMessage;
            string ActualMessage1;
            ActualMessage= profileObj.EmptyScenario(LanguageName,LanguageType);
            ActualMessage1=profileObj.EmptyScenarioofSkill(SkillName,SkillType);
            string ExpectedMessage3 = "Please enter language and level";
            Console.WriteLine("Actual message is :" + ActualMessage);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage3);
            Assert.That(ActualMessage == ExpectedMessage3, "Actual message and expected message do not match");
            string ExpectedMessage4 = "Please enter skill and experience level";
            Console.WriteLine("Actual message is :" + ActualMessage1);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage4);
            Assert.That(ActualMessage1 == ExpectedMessage4, "Actual message and expected message do not match");




        }

        [When(@"user adding by existing language including '([^']*)','([^']*)' and skill including '([^']*)','([^']*)'")]
        public void WhenUserAddingByExistingLanguageIncludingAndSkillIncluding(string LanguageName, string LanguageType, string SkillName, string SkillType)
        {
            string ActualMessage;
            string ActualSkillMessage;


            ActualMessage = profileObj.AssertByAddingDuplicateLanguage(LanguageName, LanguageType);
            ActualSkillMessage = profileObj.AssertByAddingDuplicateSkill(SkillName, SkillType);
            string ExpectedMessage = "This language is already exist in your language list.";
            Console.WriteLine("Actual message is :" + ActualMessage);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
            Assert.That(ActualMessage == ExpectedMessage, "Actual message and expected message do not match");
            string ExpectedMessage1 = "This skill is already exist in your skill list.";
            Console.WriteLine("Actual message is :" + ActualSkillMessage);
            Console.WriteLine("Expectedmessage1 is :" + ExpectedMessage1);
            Assert.That(ActualSkillMessage == ExpectedMessage1, "Actual message and expected message do not match");
            TearDown();
        }

        [Then(@"Message '([^']*)' and '([^']*)' should be display")]
        public void ThenMessageAndShouldBeDisplay(string LanguageMessage, string SkillMessage)
        {
           
            profileObj.Message(LanguageMessage);
            string ExpectedMessage = "This language is already exist in your language list.";
            Console.WriteLine(value: $"Actual message is :" + LanguageMessage);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
            Assert.That(LanguageMessage == ExpectedMessage, "Actual message and expected message do not match");
            profileObj.SkillMessage(SkillMessage);
            string ExpectedMessage1 = "This skill is already exist in your skill list.";
            Console.WriteLine("Actual message is :" + SkillMessage);
            Console.WriteLine("Expectedmessage1 is :" + ExpectedMessage1);
            Assert.That(SkillMessage == ExpectedMessage1, "Actual message and expected message do not match");

        }

        //[Then(@"Verify by adding duplicate Language and see record of language and skill including '([^']*)','([^']*)' ,'([^']*)','([^']*)' Created in the profile")]
        //public void ThenVerifyByAddingDuplicateLanguageAndSeeRecordOfLanguageAndSkillIncludingCreatedInTheProfile(string LanguageName, string LanguageType, string SkillName, string SkillType)
        //{
        //    string ActualMessage;
        //    string ActualSkillMessage;


        //    ActualMessage = profileObj.AssertByAddingDuplicateLanguage(LanguageName, LanguageType);
        //    ActualSkillMessage = profileObj.AssertByAddingDuplicateSkill( SkillName, SkillType);
        //    string ExpectedMessage = "This language is already exist in your language list.";
        //    Console.WriteLine("Actual message is :" + ActualMessage);
        //    Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
        //    Assert.That(ActualMessage==ExpectedMessage, "Actual message and expected messge do not match"); 
        //    string ExpectedMessage1 = "This skill is already exist in your skill list.";
        //    Console.WriteLine("Actual message is :" + ActualSkillMessage);
        //    Console.WriteLine("Expectedmessage1 is :" + ExpectedMessage1);
        //    Assert.That(ActualSkillMessage==ExpectedMessage1, "Actual message and expected messge do not match");
        //    TearDown();


        //}
        [When(@"Edit the already added Language and Skill Field including '([^']*)' ,'([^']*)'and'([^']*)' ,'([^']*)'")]
        public void WhenEditTheAlreadyAddedLanguageAndSkillFieldIncludingAnd(string LanguageName, string LanguageType, string SkillName, string SkillType, string MessageWithValidLang, String MessageWithValidSkill)
        {
            
            editObj.EditLangWithValid(LanguageName, LanguageType);
            editObj.EditSkillWithValid(SkillName, SkillType);


        }

        [Then(@"AlertMessage '([^']*)' and '([^']*)'should be display")]
        public void ThenAlertMessageAndShouldBeDisplay(string MessageWithValidLang, string MessageWithValidSkill)
        {
            editObj.AlertMessageLang(MessageWithValidLang);
            string ExpectedMessage = "French has been updated to your languages";
            Console.WriteLine("Actual message is :" + MessageWithValidLang);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
            Assert.That(MessageWithValidLang == ExpectedMessage, "Actual message and expected message do not match");
            editObj.AlertMessageSkill(MessageWithValidSkill);
            string ExpectedMessage1 = "SQL has been updated to your skills";
            Console.WriteLine("Actual message is :" + MessageWithValidSkill);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
            Assert.That(MessageWithValidSkill == ExpectedMessage, "Actual message and expected message do not match");

        }

        [When(@"Edit the added language and skill  with invalid inputs including '([^']*)' and '([^']*)'")]
        public void WhenEditTheAddedLanguageAndSkillWithInvalidInputsIncludingAnd(string InvalidLanguageName, string InvalidSkillName)
        {
            editObj.EditLangWithInvalid(InvalidLanguageName);
            editObj.EditSkillWithInvalid(InvalidSkillName);
            
        }

        [Then(@"Message1 '([^']*)' and '([^']*)' should be display")]
        public void ThenMessage1AndShouldBeDisplay(string MessageWithInvalidLang, string MessageWithInvalidSkill)
        {
            editObj.AlertMessageLangWithInvalid(MessageWithInvalidLang);
            string ExpectedMessage = "D344@rfgd$dtereerereer35464533 has been updated to your languages";
            Console.WriteLine("Actual message is :" + MessageWithInvalidLang);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
            Assert.That(MessageWithInvalidLang == ExpectedMessage, "Actual message and expected message do not match");
            editObj.AlertMessageSkillWithInvalid(MessageWithInvalidSkill);
            string ExpectedMessage1 = "r5676@e has been updated to your skills";
            Console.WriteLine("Actual message is :" + MessageWithInvalidSkill);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
            Assert.That(MessageWithInvalidSkill == ExpectedMessage, "Actual message and expected message do not match");



        }



        //[When(@"Edit the already added Language and Skill Field including '([^']*)' ,'([^']*)','([^']*)' ,'([^']*)'")]
        //public void ThenEditTheAlreadyAddedLanguageAndSkillFieldIncluding(string LanguageName, string LanguageType, string SkillName, string SkillType)
        //{
        //    editObj.EditLangandSkill(LanguageName, LanguageType, SkillName, SkillType);


        //}
        [Then(@"And I attempt to edit with invalid language '([^']*)' and invalid skill '([^']*)'")]
        public void ThenAndIAttemptToEditWithInvalidLanguageAndInvalidSkill(string InvalidLanguageName, string InvalidSkillName)
        {
            string ActualMessage1;
            string ActualMessage2;
            
            ActualMessage1 = editObj.EditLangWithInvalid(InvalidLanguageName);
            ActualMessage2 = editObj.EditSkillWithInvalid(InvalidSkillName); 
            string ExpectedMessage = "D344@rfgd$dtereerereer35464533 has been updated to your languages";
            Console.WriteLine("Actual message is :" + ActualMessage1);
            Console.WriteLine("Expectedmessage1 is :" + ExpectedMessage);
            string ExpectedMessage1 = "r666555 has been updated to your skills";
            Console.WriteLine("Actual message is :" + ActualMessage2);
            Console.WriteLine("Expectedmessage2 is :" + ExpectedMessage1);
            Assert.That(ActualMessage1==ExpectedMessage, "Actual message and expected messge do not match");
            Assert.That(ActualMessage2==ExpectedMessage1, "Actual message and expected messge do not match");
            TearDown();


        }

        [Then(@"I delete the selected language and skill")]
        public void ThenIDeleteTheSelectedLanguageAndSkill()
        {
            deleteObj.DeleteOption();
            TearDown();

        }

        
    





    }
}
