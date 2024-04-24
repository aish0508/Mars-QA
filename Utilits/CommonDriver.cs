using AdvancedTaskPart1.Pages.SignIn;
using AventStack.ExtentReports.Model;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Utilits
{
    public class CommonDriver
    {
        public static IWebDriver dr;
        public static ExtentReports extent;
        public static ExtentTest test;
        Login loginObj;


        [OneTimeSetUp]
        public static void ExtentStart()
        {
             
            if (extent == null)
            {
                extent = new ExtentReports();
                var SparkReporter = new ExtentSparkReporter(@"C:\Users\owner\OneDrive\Documents\Mars-QA\MarsQA-Advanced Task\Advanced Task Part1\AdvancedTaskPart1\AdvancedTaskPart1\ExtentReport\\Extent.html");
                extent.AttachReporter(SparkReporter);
            }
        }
        [SetUp]
        public void Initialize()
        {
           

        ////Open Chrome Browser
        dr = new ChromeDriver();
        //Maximize the browser
        dr.Manage().Window.Maximize();
        dr.Navigate().GoToUrl("http://localhost:5000/Home");
        test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }
        [TearDown]
        public void TearDown()
        {
            // If tests fails capture screenshot
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                string testName = TestContext.CurrentContext.Test.Name;
                test.Log(Status.Fail, $"Tests  '{testName}' failed");
                //  CaptureScreenshot(testName);
            }


            // Close the browser after each test
            dr.Dispose();
        }
        [OneTimeTearDown]
        public static void ExtentClose()
        {
            extent.Flush();
        }
        public void CaptureScreenshot(string testName)
        {
            string screenshotFileName = $"screenshot_{testName}";
            ITakesScreenshot ts = (ITakesScreenshot)dr;
            Screenshot screenshot = ts.GetScreenshot();
            string filePath = "C:\\Users\\owner\\OneDrive\\Documents\\Mars-QA\\MarsQA-Advanced Task\\Advanced Task Part1\\AdvancedTaskPart1\\AdvancedTaskPart1\\Screenshot";
            string screenshotPath = Path.Combine(filePath, $"{screenshotFileName}_{DateTime.Now:yyyyMMdd_HHmmss}.png");
            screenshot.SaveAsFile(screenshotPath);
        }

    }
}
