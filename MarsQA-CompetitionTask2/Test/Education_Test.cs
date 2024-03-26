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
using System.Net.NetworkInformation;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.Text.RegularExpressions;
using MarsQA_CompetitionTask2.Data;




namespace MarsQA_CompetitionTask2.Test
{

    [TestFixture]
    public class Education_Test : CommonDriver
    {
        Login loginobj;
        Profile profileobj;
        Edit editObj;
        Delete deleteObj;
        EducationData educationData;
        public static ExtentReports extent;
        public static ExtentTest test;



        public Education_Test()
        {
            loginobj = new Login();
            profileobj = new Profile();
            editObj = new Edit();
            deleteObj = new Delete();
            
        }
        [OneTimeSetUp]
        public static void ExtentStart()
        {
            //Create new instance of ExtentReports
            extent = new ExtentReports();
            //Create new instance of ExtentSparkReporter
            var sparkReporter = new ExtentSparkReporter(@"C:\Users\owner\OneDrive\Documents\Mars-QA\MarsQA-CompetitionTask2\MarsQA-CompetitionTask2\Extent Reports\Education.html");
            //Attach the ExtentSparkReporter to the ExtentReports
            extent.AttachReporter(sparkReporter);
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
            test = extent.CreateTest("Delete_AllRecords").Info("Test started");
            deleteObj.DeleteEducation();
            test.Log(Status.Pass, "Delete_AllRecords passed");
        }

        [Test, Order(2), Description("This test is adding Education in the profile")]
        public void Education()
        {
            test = extent.CreateTest("Add_Education").Info("Test started");
            // Profile object initialization and definition
            // Read test data for the AddEducation test case
            List<EducationData> educationDataList = EducationDataHelper.ReadEducationData(@"AddEducationData.json");

            // Iterate through test data and retrieve AddEducation test data
            foreach (var educationData in educationDataList)
            {
                Console.WriteLine(educationData.UniversityName);
                profileobj.AddEducation(educationData);
                test.Log(Status.Pass, "Added Education Passed");
            }


        }
        [Test, Order(3), Description("This test is verifying by adding duplicate Education ")]
        public void VerifyByDuplicateEducation()
        {
            test = extent.CreateTest("Update_EducationByAddingDulicateValue ").Info("Test started");
            List<EducationData>educationDataList = EducationDataHelper.ReadEducationData(@"AddExistingEducation.json");
            // Iterate through test data and retrieve AddEducation test data
            foreach (var educationData in educationDataList)
            {
                String ActualMessage;
                Console.WriteLine(educationData.UniversityName);
                ActualMessage = profileobj.Validatebyaddingduplicateeducation(educationData);
                String ExpectedMessage = "This information is already exist.";
                Console.WriteLine("Actual message is :" + ActualMessage);
                Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
                Assert.That(ActualMessage.Equals(ExpectedMessage), "Actual Message and Expected Message do not match");
                test.Log(Status.Pass, "Update_Education passed");

            }

               
        }
        [Test, Order(4), Description("This test is validating Empty Scenario")]
        public void ValidateByEmptyScenario()
        {
            test = extent.CreateTest("EmptyTextbox_Education").Info("Test started");
            string ActualMessage;
            ActualMessage = profileobj.ValidateEmptyScenario();
            string ExpectedMessage = "Please enter all the fields";
            Console.WriteLine("Actual message is :" + ActualMessage);
            Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
            Assert.That(ActualMessage.Equals(ExpectedMessage), "Actual Message and Expected Message do not match");
            test.Log(Status.Pass, "EmptyTextbox_Education passed");
        }
        [Test ,Order(5),Description("This test is validate Empty Scenario with Entering some field")]
        public void ValidateEmptyScenarioByFillingSomeField()  
        {
            test = extent.CreateTest("EmptyTextbox_EducationByFillingSomeField").Info("Test started");
            List<EducationData> educationDataList = EducationDataHelper.ReadEducationData(@"EmptyScenarioData.json");
            foreach (var educationData in educationDataList)
            {
                string ActualMessage1;
                ActualMessage1 = profileobj.ValidateEmptyScenarioWithEnteringsomeField(educationData);
                string ExpectedMessage1 = "Please enter all the fields";
                Console.WriteLine("Actual message is :" + ActualMessage1);
                Console.WriteLine("Expectedmessage is :" + ExpectedMessage1);
                Thread.Sleep(1000);
                Assert.That(ActualMessage1.Equals(ExpectedMessage1), "Actual Message and Expected Message do not match");
                test.Log(Status.Pass, "EmptyTextbox_Education passed");
            }
                
        }
        [Test, Order(6), Description("This test is Editing the existing education with Valid Input")]
        public void Edit()
        {
            test = extent.CreateTest("Edit_Education").Info("Test started");
            List<EducationData> educationDataList = EducationDataHelper.ReadEducationData(@"EditEducation.json");
            foreach (var educationData in educationDataList)
            {
                //Update Education
                editObj.EditEducation(educationData);
                test.Log(Status.Pass, "Edit_Education passed");
            }



        }
        [Test , Order(7),Description("This test is editing the exiting education with Invalid Input")]
        public void  EditEducationWithInvalid()
        {
            test = extent.CreateTest("Edit_EducationWithInvalidInput").Info("Test started");
            List<EducationData> educationDataList = EducationDataHelper.ReadEducationData(@"EditEducationWithInvalid .json");
            foreach (var educationData in educationDataList)
            {
                string ActualMessage;
                ActualMessage = editObj.EditEducationWithInvalid(educationData);
                String ExpectedMessage = "SpecialCharacter are not allowed";
                Console.WriteLine("Actual message is :" + ActualMessage);
                Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
                // Check if the UniversityName contains special characters
                bool containsSpecialChars = ContainsSpecialCharacters(educationData.UniversityName);
                if (containsSpecialChars)
                {

                    try
                    {

                        Assert.That(ActualMessage.Equals(ExpectedMessage), "Actual Message and Expected Message do not match");
                        test.Log(Status.Pass, "Education passed");
                        // If information already exists, call the cancel method
                        if (ActualMessage == "This information is already exist.")
                        {
                            editObj.getCancel();
                        }
                    }
                    catch (AssertionException ex)
                    {
                        // Log the failure and capture a screenshot
                        test.Log(Status.Fail, "Education failed: " + ex.Message);
                        Console.WriteLine(ActualMessage);
                        CaptureScreenshot("EducationTestFailed");
                    }
                }
            }


        }

        [OneTimeTearDown]
        public static void ExtentClose()
        {
            //Flush the ExtentReports instance
            extent.Flush();
        }
    }
}

