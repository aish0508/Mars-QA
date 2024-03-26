using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using MarsQA_CompetitionTask2.Pages.Skill;
using MarsQA_CompetitionTask2.Utilits;
using NUnit.Framework;
using NUnit.Framework.Internal.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQA_CompetitionTask2.Data;

namespace MarsQA_CompetitionTask2.Test
{
    public class Certificate_Test : CommonDriver
    {
        Login loginobj;
        Profile profileobj;
        Edit editObj;
        Delete deleteObj;
        CertificationData CertificationData;
        public static ExtentReports extent;
        public static ExtentTest test;



        public Certificate_Test()
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
            var sparkReporter = new ExtentSparkReporter(@"C:\Users\owner\OneDrive\Documents\Mars-QA\MarsQA-CompetitionTask2\MarsQA-CompetitionTask2\Extent Reports\Certification.html");
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
        [Test, Order(1), Description("This test is Deleting Certificate")]
        public void Delete()
        {
            test = extent.CreateTest("Delete_AllRecords").Info("Test started");
            deleteObj.DeleteCertificate();
            test.Log(Status.Pass, "Delete_AllRecords passed");
        }

        [Test, Order(2), Description("This test is adding Certificate in the profile")]
        public void Certificate()
        {
            test = extent.CreateTest("Add_Certification").Info("Test started");
            // Profile object initialization and definition
            List<CertificationData> certificationDataList = CertificationDataHelper.ReadCertificationData(@"AddCertificationData.json");

            // Iterate through test data and retrieve AddCertification test data
            foreach (var CertificationData in certificationDataList)
            {
                Console.WriteLine(CertificationData.Certificate);
                Thread.Sleep(1000);
                profileobj.AddCertificate(CertificationData);
                test.Log(Status.Pass, "Added Certification Passed");
            }



        }
        [Test, Order(3), Description("This Test is validating duplicate Secenario ")]
        public void ValidateByAddingDuplicate()
        {
            test = extent.CreateTest("ValidateByAddingDuplicateInputs ").Info("Test started");
            List<CertificationData> certificationDataList = CertificationDataHelper.ReadCertificationData(@"AddExistingCertification.json");

            // Iterate through test data and retrieve AddExitingCertification test data
            foreach (var CertificationData in certificationDataList)
            {
                String ActualMessage;
                ActualMessage = profileobj.VaditeByAddingDuplicateCertificate(CertificationData);
                String ExpectedMessage = "This information is already exist.";
                Console.WriteLine("Actual message is :" + ActualMessage);
                Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
                Assert.That(ActualMessage.Equals(ExpectedMessage), "Actual Message and Expected Message do not match");
                test.Log(Status.Pass, "ValidationOfDuplicateInputs passed");
            }
        }
        [Test,Order(4),Description("This Test is Validating Empty Scenario")]
        public void EmptyScenario()
        {
            test = extent.CreateTest("EmptyTextbox_Certification").Info("Test started");
            {
                string ActualMessage;
                ActualMessage = profileobj.ValidateEmptyScenario();
                string ExpectedMessage = "Please enter Certification Name, Certification From and Certification Year";
                Console.WriteLine("Actual message is :" + ActualMessage);
                Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
                Thread.Sleep(1000);
                Assert.That(ActualMessage.Equals(ExpectedMessage), "Actual Message and Expected Message do not match");
                test.Log(Status.Pass, "EmptyScenario passed");
            }
        }
        [Test, Order(5), Description("This Test is Validating Empty Scenario By Filling Some Field")]
        public void EmptyScenarioByFillingSomeField()
       
        {
            test = extent.CreateTest("EmptyScenarioByFillingSomeField").Info("Test started");
            List<CertificationData> certificationDataList = CertificationDataHelper.ReadCertificationData(@"EmptySceranioCerticateData.json");

            // Iterate through test data and retrieve EmptyScenarioCertificate test data
            foreach (var CertificationData in certificationDataList)
            {

                string ActualMessage1;
                ActualMessage1 = profileobj.ValidateEmptyScenarioByFillingSomeField(CertificationData);
                string ExpectedMessage1 = "Please enter Certification Name, Certification From and Certification Year";
                Console.WriteLine("Actual message is :" + ActualMessage1);
                Console.WriteLine("Expectedmessage is :" + ExpectedMessage1);
                Thread.Sleep(1000);
                Assert.That(ActualMessage1.Equals(ExpectedMessage1), "Actual Message and Expected Message do not match");
                test.Log(Status.Pass, "EmptyScenarioByFillingSomeField passed");
            }
        }
        [Test , Order(6), Description("This Test is Editing Certificate with Valid Input")]
        public void Edit()
        {
            test = extent.CreateTest("UpdateCertificated").Info("Test started");
            List<CertificationData> certificationDataList = CertificationDataHelper.ReadCertificationData(@"EditCertificateData.json");

            // Iterate through test data and retrieve EmptyScenarioCertificate test data
            foreach (var CertificationData in certificationDataList)
            {

                editObj.EditCertificate(CertificationData);
                test.Log(Status.Pass, "UpdateCertificate passed");
            }
        }
        [Test, Order(7), Description("This Test is Editing Certificate with Invalid Inputs")]
        public void EditwithInvalidInput()
        {
            test = extent.CreateTest("UpdateCertificatedWithInvalidInput").Info("Test started");
            List<CertificationData> certificationDataList = CertificationDataHelper.ReadCertificationData(@"EditCertificationWithInvalidData.json");

            // Iterate through test data and retrieve EmptyScenarioCertificate test data
            foreach (var CertificationData in certificationDataList)
            {
                string ActualMessage;
                ActualMessage = editObj.EditCertificateWithInvalidInput(CertificationData);
                // Check if the Certificate contains special characters
                String ExpectedMessage = "SpecialCharacter are not allowed";
                Console.WriteLine("Actual message is :" + ActualMessage);
                Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
                bool containsSpecialChars = ContainsSpecialCharacters(CertificationData.Certificate);
                if (containsSpecialChars)
                {
                    try
                    {
                        // Verify that the actual message matches the expected message for special characters
                        Assert.That(ActualMessage == "Special characters are not allowed", "Actual message and expected message do not match");
                    }
                    catch (AssertionException ex)
                    {
                        // Log the failure and capture a screenshot
                        test.Log(Status.Fail, "SpecialCharacters Certification failed" + ex.Message);
                        Console.WriteLine(ActualMessage);
                        CaptureScreenshot("SpecialCharsCertificationFailed");
                    }
                }
                //else
                //{
                //    // Verify if special characters are not present in the Certificate
                //    if (editObj.getCertificate(certificationData.Certificate) == certificationData.Certificate)
                //    {
                //        Assert.That(editObj.getCertificate(certificationData.Certificate) == certificationData.Certificate, "Actual certificate and expected certificate do not match");
                //        Assert.That(editObj.getCertifiedFrom(certificationData.CertifiedFrom) == certificationData.CertifiedFrom, "Actual certifiedFrom and expected certifiedFrom do not match");
                //        Assert.That(editObj.getYear(certificationData.Year) == certificationData.Year, "Actual year and expected year do not match");
                //        Console.WriteLine(ActualMessage);
                //    }
                //    try
                //    {
                //        Assert.That(ActualMessage == "ISTQB has been added to your certification" || actualMessage == "This information is already exist.", "Actual message and expected message do not match");
                //        test.Log(Status.Pass, "Certification passed");
                //        // If information already exists, call the cancel method
                //        if (ActualMessage == "This information is already exist.")
                //        {
                //            editObj.getCancel();
                //        }
                //    }
                //    catch (AssertionException ex)
                //    {
                //        // Log the failure and capture a screenshot
                //        test.Log(Status.Fail, "Certification failed: " + ex.Message);
                //        Console.WriteLine(ActualMessage);
                //        CaptureScreenshot("CertificationTestFailed");
                //    }
                //}
                //Assert.That(ActualMessage.Equals(ExpectedMessage), "Actual Message and Expected Message do not match");
                //test.Log(Status.Pass, "UpdateCertificateWithInvalidInput passed");
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

