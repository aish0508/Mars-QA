using MarsQA_CompetitionTask2.Pages.Skill;
using MarsQA_CompetitionTask2.Utilits;
using NUnit.Framework;
using NUnit.Framework.Internal.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_CompetitionTask2.Test
{
    public class Certificate_Test : CommonDriver
    {
        Login loginobj;
        Profile profileobj;
        Edit editObj;
        Delete deleteObj;


        public Certificate_Test()
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
        [Test, Order(1), Description("This test is Deleting Certificate")]
        public void Delete()
        {
            deleteObj.DeleteCertificate();
        }

        [Test, Order(2), Description("This test is adding Certificate in the profile")]
        public void Certificate()
        {

            // Profile object initialization and definition

            profileobj.AddCertificate();


        }
        [Test, Order(3), Description("This Test is validating duplicate Secenario ")]
        
          public void ValidateByAddingDuplicate()
        {
            String ActualMessage;
            ActualMessage = profileobj.VaditeByAddingDuplicateCertificate();
            String ExpectedMessage = "This information is already exist.";
            Console.WriteLine("Actual message is :" + ActualMessage);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
            Assert.That(ActualMessage.Equals(ExpectedMessage), "Actual Message and Expected Message do not match");
        }
        [Test,Order(4),Description("This Test is Validating Empty Scenario")]
        public void EmptyScenario()
        {
            string ActualMessage;
            ActualMessage=profileobj.ValidateEmptyScenario();
            string ExpectedMessage = "Please enter Certification Name, Certification From and Certification Year";
            Console.WriteLine("Actual message is :" + ActualMessage);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
            Thread.Sleep(1000);
            Assert.That(ActualMessage.Equals(ExpectedMessage), "Actual Message and Expected Message do not match");
        }
        [Test, Order(5), Description("This Test is Validating Empty Scenario By Filling Some Field")]
        public void EmptyScenarioByFillingSomeField()
        {
            string ActualMessage1;
            ActualMessage1 = profileobj.ValidateEmptyScenarioByFillingSomeField();
            string ExpectedMessage1 = "Please enter Certification Name, Certification From and Certification Year";
            Console.WriteLine("Actual message is :" + ActualMessage1);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage1);
            Thread.Sleep(1000);
            Assert.That(ActualMessage1.Equals(ExpectedMessage1), "Actual Message and Expected Message do not match");
        }
        [Test , Order(6), Description("This Test is Editing Certificate with Valid Input")]
        public void Edit()
        {
            editObj.EditCertificate();
        }
        [Test, Order(7), Description("This Test is Editing Certificate with Invalid Inputs")]
        public void EditwithInvalidInput()
        {
            string ActualMessage;
            ActualMessage = editObj.EditCertificateWithInvalidInput();
            String ExpectedMessage = "$####1233546456464564fgfgghdgfsfs*6866() has been updated to your certification";
            Console.WriteLine("Actual message is :" + ActualMessage);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
            Assert.That(ActualMessage.Equals(ExpectedMessage), "Actual Message and Expected Message do not match");

        }

        //[TearDown]
        //public void TearDown()
        //{
        //    TearDown();

        //}

    }
    }

