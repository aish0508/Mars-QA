using MarsQA_CompetitionTask2.Utilits;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal.Commands;
using MarsQA_CompetitionTask2.Pages.Education;

namespace MarsQA_CompetitionTask2.Test
{

    [TestFixture]
    public class Education_Test : CommonDriver
    {
        Login loginobj;
        Profile profileobj;
        Edit editObj;
        Delete deleteObj;


        public Education_Test()
        {
            loginobj = new Login();
            profileobj = new Profile();
            editObj = new Edit();
            deleteObj = new Delete();


        }
        
        [SetUp]
        public void Login()
        {


            //Open Chrome Browser
            Initialize();
            // dr = new ChromeDriver();
            //Maximize the browser
            //  dr.Manage().Window.Maximize();

            //Login page object initialization and deifinition
            loginobj.LoginActions();
        }
        [Test, Order(1), Description("This test is Deleting Education")]
        public void Delete()
        {
            deleteObj.DeleteEducation();
        }

        [Test, Order(2), Description("This test is adding Education in the profile")]
        public void Education()
        {

            // Profile object initialization and definition

            profileobj.AddEducation();


        }
        [Test, Order(3), Description("This test is verifying by adding duplicate Education ")]
        public void VerifyByDuplicateEducation()
        {
            String ActualMessage;
            ActualMessage = profileobj.Validatebyaddingduplicateeducation();
            String ExpectedMessage = "This information is already exist.";
            Console.WriteLine("Actual message is :" + ActualMessage);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
            Assert.That(ActualMessage.Equals(ExpectedMessage), "Actual Message and Expected Message do not match");
        }
        [Test, Order(4), Description("This test is validating Empty Scenario")]
        public void ValidateByEmptyScenario()
        {
            string ActualMessage;
            ActualMessage = profileobj.ValidateEmptyScenario();
            string ExpectedMessage = "Please enter all the fields";
            Console.WriteLine("Actual message is :" + ActualMessage);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
            Assert.That(ActualMessage.Equals(ExpectedMessage), "Actual Message and Expected Message do not match");
        }
        [Test ,Order(5),Description("This test is validate Empty Scenario with Entering some field")]
        public void ValidateEmptyScenarioByFillingSomeField()  
        {
            string ActualMessage1;
            ActualMessage1 = profileobj.ValidateEmptyScenarioWithEnteringsomeField();
            string ExpectedMessage1 = "Please enter all the fields";
            Console.WriteLine("Actual message is :" + ActualMessage1);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage1);
            Thread.Sleep(1000);
            Assert.That(ActualMessage1.Equals(ExpectedMessage1), "Actual Message and Expected Message do not match");
        }
        [Test, Order(6), Description("This test is Editing the existing education with Valid Input")]
        public void Edit()
        {
            
            editObj.EditEducation();
            

        }
        [Test , Order(7),Description("This test is editing the exiting education with Invalid Input")]
        public void  EditEducationWithInvalid()
        {
            string ActualMessage;
            ActualMessage=editObj.EditEducationWithInvalid();
            String ExpectedMessage = "Education as been updated";
            Console.WriteLine("Actual message is :" + ActualMessage);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
            Assert.That(ActualMessage.Equals(ExpectedMessage), "Actual Message and Expected Message do not match");


        }

        //[TearDown]
        //public void OneTimeTearDown()
        //{
        //    OneTimeTearDown();

        //}
    }
}

