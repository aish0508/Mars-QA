using Aspose.Cells.Drawing;
using Mars_QA.Pages;
using Mars_QA.Utilis;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using Mars_QA.Hooks;



namespace Mars_QA.StepsDefinition
{
    [Binding]
    public class LanguageStepDefinitions : CommonDriver
    {
        Login loginPageObj;
        LanguageProfile profileObj;
        LanguageEdit editObj;
        

        public string ActualSkillMessage { get; private set; }

        public LanguageStepDefinitions()
        {
            loginPageObj = new Login();
            profileObj = new LanguageProfile();
            editObj = new LanguageEdit();
            
        }

        [Given(@"I Logged into a portal")]
        public void GivenILoggedIntoAPortal()
        {
            //// Open Chrome Browser
            //Initialize();
            // Login page object initialization and definition
            loginPageObj.LoginActions();
            
        }
        [Then(@"delete all the languages from the language list")]
        public void ThenDeleteAllTheLanguagesFromTheLanguageList()
        {
            //delete all record from the language list 
            profileObj.DeleteAllRecords();
            

        }

        [Then(@"I Clicked On Language Tab and Add Language Including '([^']*)' , '([^']*)'")]
        public void ThenIClickedOnLanguageTabAndAddLanguageIncluding(string LanguageName, string LanguageType)
        {
            profileObj.AddLanguage(LanguageName, LanguageType);
            

        }
        
        [When(@"User leaves language textbox including  '([^']*)' ,'([^']*)' as empty")]
        public void WhenUserLeavesLanguageTextboxIncludingAsEmpty(string LanguageName, string LanguageType)
        {
            string ActualMessage;
            ActualMessage= profileObj.EmptyScenario(LanguageName,LanguageType);
            string ExpectedMessage3 = "Please enter language and level";
            Console.WriteLine("Actual message is :" + ActualMessage);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage3);
            Assert.That(ActualMessage == ExpectedMessage3, "Actual message and expected message do not match");
         
        }

        [When(@"user adding by existing language including '([^']*)','([^']*)'")]
        public void WhenUserAddingByExistingLanguageIncludingAndSkillIncluding(string LanguageName, string LanguageType)
        {
            string ActualMessage;
            ActualMessage = profileObj.AssertByAddingDuplicateLanguage(LanguageName, LanguageType);
            //string ExpectedMessage = "This language is already exist in your language list.";
            //Console.WriteLine("Actual message is :" + ActualMessage);
            //Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
            //Assert.That(ActualMessage == ExpectedMessage, "Actual message and expected message do not match");
            
        }
        [Then(@"DuplicateMessage '([^']*)' should be display")]
        public void ThenDuplicateMessageShouldBeDisplay(string LanguageMessage)
        {
            profileObj.Message(LanguageMessage);
            string ExpectedMessage = "This language is already exist in your language list.";
            Console.WriteLine(value: $"Actual message is :" + LanguageMessage);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
            Assert.That(LanguageMessage == ExpectedMessage, "Actual message and expected message do not match");
        }
                       
        [When(@"Edit the already added Language  Field including '([^']*)' ,'([^']*)'")]
        public void WhenEditTheAlreadyAddedLanguageFieldIncluding(string LanguageName, string LanguageType)
        {
            editObj.EditLangWithValid(LanguageName, LanguageType);
        }

        [When(@"Edit the added language with invalid inputs including '([^']*)'")]
        public void WhenEditTheAddedLanguageWithInvalidInputsIncluding(string InvalidLanguageName)
        {
            string ActualMessage1;


            ActualMessage1 = editObj.EditLangWithInvalid(InvalidLanguageName);
            //string ExpectedMessage = "D344@rfgd$dtereerereer35464533 has been updated to your languages";
            //Console.WriteLine("Actual message is :" + ActualMessage1);
            //Console.WriteLine("Expectedmessage1 is :" + ExpectedMessage);
            //Assert.That(ActualMessage1 == ExpectedMessage, "Actual message and expected messge do not match");

        }
        [Then(@"Edit_AlertMessage '([^']*)' should be display")]
        public void ThenEdit_AlertMessageShouldBeDisplay(string MessageWithValidLang)
        {
            editObj.AlertMessageLang(MessageWithValidLang);
            string ExpectedMessage2 = "French has been updated to your languages";
            Console.WriteLine("Actual message is :" + MessageWithValidLang);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage2);
            Assert.That(MessageWithValidLang == ExpectedMessage2, "Actual message and expected message do not match");

        }
        [Then(@"EditMessage '([^']*)'  should be display")]
        public void ThenEditMessageShouldBeDisplay(string MessageWithInvalidLang)
        {
            editObj.AlertMessageLangWithInvalid(MessageWithInvalidLang);
            string ExpectedMessage = "D344@rfgd$dtereerereer35464533 has been updated to your languages";
            Console.WriteLine("Actual message is :" + MessageWithInvalidLang);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
            Assert.That(MessageWithInvalidLang == ExpectedMessage, "Actual message and expected message do not match");
        }

        
   }
}
