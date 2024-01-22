using Mars_QA.Pages;
using Mars_QA.Utilis;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars_QA.StepsDefinition
{
    [Binding]
    public class StepDefinitions : CommonDriver
    {
        Login loginPageObj = new Login();
        Profile profileObj = new Profile();
        Edit editObj = new Edit();
        Delete deleteObj = new Delete();
        [Given(@"Navigate to Profile Page")]
        public void GivenNavigateToProfilePage()
        {
            //Open Chrome Browser
            dr = new ChromeDriver();
            //Maximize the browser
            dr.Manage().Window.Maximize();
            // Login page object initialization and definition
            loginPageObj.LoginActions(dr);
        }

        [When(@"In Description tab Add languages and skills")]
        public void WhenInDescriptionTabAddLanguagesAndSkills()
        {
            profileObj.GoToProfilePage(dr);
        }

        [Then(@"Verify by add duplicate language")]
        public void ThenVerifyByAddDuplicateLanguage()
        {
            profileObj.GoToProfilePage(dr);
        }
                   
        [Then(@"In Description tab Edit the language field and Skill field")]
        public void ThenInDescriptionTabEditTheLanguageFieldAndSkillField()
        {
            editObj.EditLang(dr);
        }
                       
        [Then(@"In Skills tab delete the language and skill")]
        public void ThenInSkillsTabDeleteThelanguageandskill()
        {
            deleteObj.DeleteOption(dr);
        }
    }
}
