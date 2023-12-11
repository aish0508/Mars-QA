

using Mars_QA.Pages;
using Mars_QA.Utilis;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;


namespace Mars_QA.StepsDefinition
{
    public class UserStepDefinition : CommonDriver
    {
        Login loginObj = new Login();

        [Given(@"Navigate to User Profile Page")]
        public void GivenNavigatetoUserProfilePage()
        {
            //Open Chrome browser
            dr = new ChromeDriver();

            // Login page object initialization and definition

            loginObj.LoginActions(dr);
        }

        [When(@"In Description tab Add Languages And Skills")]
        public void InDescriptiontabAddLanguagesAndSkills()
        {
            // Home page object initialization and deifinition


        }

        [When(@"In User Profile edit Language and Skills ")]
        public void InUserProfileeditLanguageandSkills()
        {



        }
        [Then(@"In User Profile delete added Language and Skills")]
        public void InUserProfileDeleteaddedlanguageandSkills()
        {

        }




    }
}