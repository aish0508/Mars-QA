using Mars_QA.Pages;
using Mars_QA.Utilis;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Mars_QA.Hooks;
using static Mars_QA.Pages.Login;
using static Mars_QA.Pages.HomePage;
using Aspose.Cells.Drawing;
using OpenQA.Selenium;

namespace Mars_QA.StepsDefinition
{
    [Binding]
    public class SkillStepDefinitions : CommonDriver
    {
        HomePage homePageObj;
        SkillProfile profileObj;
        EditSkill editObj;
        public SkillStepDefinitions()
        {
            homePageObj = new HomePage();
            profileObj = new SkillProfile();
            editObj = new EditSkill();

        }
        [When(@"User navigate to Skill Tab")]
        public void WhenUserNavigateToSkillTab()
        {
            Thread.Sleep(3000);
            homePageObj.GoToSkillsPage();
            //IWebElement skillsTab = dr.FindElement(By.XPath("//a[@data-tab='second']"));
                      
            //    Thread.Sleep(1000);
            //    skillsTab.Click();
            
        }
        [Then(@"delete all the skill from the skill list")]
        public void ThenDeleteAllTheSkillFromTheSkillList()
        {
            //Delete all records from the skill list
            profileObj.DeleteAllRecords();
        }
        [Then(@"Add Skill Including '([^']*)' , '([^']*)'")]
        public void ThenAddSkillIncluding(string SkillName, string SkillType)
        {
            //By calling profile object then call addskill method
            profileObj.AddSkills(SkillName, SkillType);
        }
        [Then(@"User leaves Skill textbox '([^']*)' ,'([^']*)' as empty")]
        public void ThenUserLeavesSkillTextboxAsEmpty(string SkillName, string SkillType)
        {
            string ActualMessage1;
            ActualMessage1 = profileObj.EmptyScenarioofSkill(SkillName, SkillType);
            string ExpectedMessage4 = "Please enter skill and experience level";
            Console.WriteLine("Actual message is :" + ActualMessage1);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage4);
            Assert.That(ActualMessage1 == ExpectedMessage4, "Actual message and expected message do not match");

        }



        [Then(@"user adding by existing skill including '([^']*)','([^']*)'")]
        public void ThenUserAddingByExistingSkillIncluding(string SkillName, string SkillType)
        {
            string ActualSkillMessage;
            ActualSkillMessage = profileObj.AssertByAddingDuplicateSkill(SkillName, SkillType);
            string ExpectedMessage1 = "This skill is already exist in your skill list.";
            Console.WriteLine("Actual message is :" + ActualSkillMessage);
            Console.WriteLine("Expectedmessage1 is :" + ExpectedMessage1);
            Assert.That(ActualSkillMessage == ExpectedMessage1, "Actual message and expected message do not match");

        }

        [Then(@"Message '([^']*)' should be display")]
        public void ThenMessageShouldBeDisplay(string SkillMessage)
        {
            profileObj.SkillMessage(SkillMessage);
            string ExpectedMessage1 = "This skill is already exist in your skill list.";
            Console.WriteLine("Actual message is :" + SkillMessage);
            Console.WriteLine("Expectedmessage1 is :" + ExpectedMessage1);
            Assert.That(SkillMessage == ExpectedMessage1, "Actual message and expected message do not match");
            
        }

        [Then(@"Edit the already added Skill Field including '([^']*)' ,'([^']*)'")]
        public void ThenEditTheAlreadyAddedSkillFieldIncluding(string SkillName, string SkillType)
        {
            editObj.EditSkillWithValid(SkillName, SkillType);
        }

        [Then(@"AlertMessage '([^']*)' should be display")]
        public void ThenAlertMessageShouldBeDisplay(string MessageWithValidSkill)
        {
            editObj.AlertMessageSkill(MessageWithValidSkill);
            string ExpectedMessage1 = "SQL has been updated to your skills";
            Console.WriteLine("Actual message is :" + MessageWithValidSkill);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage1);
            Assert.That(MessageWithValidSkill == ExpectedMessage1, "Actual message and expected message do not match");
            
        }

        [Then(@"Edit the added skill with invalid inputs including '([^']*)'")]
        public void WhenEditTheAddedSkillWithInvalidInputsIncluding(string InvalidSkillName)
        {
            string ActualMessage2;
            ActualMessage2 = editObj.EditSkillWithInvalid(InvalidSkillName);
            string ExpectedMessage1 = "r5676@e has been updated to your skills";
            Console.WriteLine("Actual message is :" + ActualMessage2);
            Console.WriteLine("Expectedmessage2 is :" + ExpectedMessage1);
            Assert.That(ActualMessage2 == ExpectedMessage1, "Actual message and expected messge do not match");
            


        }

        [Then(@"Message1 '([^']*)' should be display")]
        public void ThenMessage1ShouldBeDisplay(string MessageWithInvalidSkill)
        {
            editObj.AlertMessageSkillWithInvalid(MessageWithInvalidSkill);
            string ExpectedMessage1 = "r5676@e has been updated to your skills";
            Console.WriteLine("Actual message is :" + MessageWithInvalidSkill);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage1);
            Assert.That(MessageWithInvalidSkill == ExpectedMessage1, "Actual message and expected message do not match");
            ////close browser
            //TearDown();

        }
    }
}
