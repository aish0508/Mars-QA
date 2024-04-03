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
using System.Security.Cryptography.X509Certificates;

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
        //[SetUp] 
        //public void SetUp()
        //{ 
        //    Initialize();
        //    loginobj.LoginActions();
        //}
        
        [Test, Order(1), Description("This test is Deleting Certificate")]
        public void Delete()
        {
          
            deleteObj.DeleteCertificate();
           
        }

        [Test, Order(2), Description("This test is adding Certificate in the profile")]
        public void Certificate()
        {
           
            // Profile object initialization and definition
            List<CertificationData> certificationDataList = CertificationDataHelper.ReadCertificationData(@"AddCertificationData.json");

            // Iterate through test data and retrieve AddCertification test data
            foreach (var CertificationData in certificationDataList)
            {
                Console.WriteLine(CertificationData.Certificate);
                Thread.Sleep(1000);
                profileobj.AddCertificate(CertificationData);
               
            }



        }
        [Test, Order(3), Description("This Test is validating duplicate Secenario ")]
        public void ValidateByAddingDuplicate()
        {
           
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
               
            }
        }
        [Test,Order(4),Description("This Test is Validating Empty Scenario")]
        public void EmptyScenario()
        {
            
            {
                string ActualMessage;
                ActualMessage = profileobj.ValidateEmptyScenario();
                string ExpectedMessage = "Please enter Certification Name, Certification From and Certification Year";
                Console.WriteLine("Actual message is :" + ActualMessage);
                Console.WriteLine("Expectedmessage is :" + ExpectedMessage);
                Thread.Sleep(1000);
                Assert.That(ActualMessage.Equals(ExpectedMessage), "Actual Message and Expected Message do not match");
            
            }
        }
        [Test, Order(5), Description("This Test is Validating Empty Scenario By Filling Some Field")]
        public void EmptyScenarioByFillingSomeField()
       
        {
           
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
               
            }
        }
        [Test , Order(6), Description("This Test is Editing Certificate with Valid Input")]
        public void Edit()
        {
            
            List<CertificationData> certificationDataList = CertificationDataHelper.ReadCertificationData(@"EditCertificateData.json");

            // Iterate through test data and retrieve EmptyScenarioCertificate test data
            foreach (var CertificationData in certificationDataList)
            {

                editObj.EditCertificate(CertificationData);
               
            }
        }
        [Test, Order(7), Description("This Test is Editing Certificate with Invalid Inputs")]
        public void EditwithInvalidInput()
        {
           
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
              
            }


        }
        
   

    }
    }

