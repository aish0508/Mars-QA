using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQA_CompetitionTask2.Pages.Education;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace MarsQA_CompetitionTask2.Utilits
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
                var SparkReporter = new ExtentSparkReporter(@"C:\\Users\\owner\\OneDrive\\Documents\\Mars-QA\\MarsQA-CompetitionTask2\\MarsQA-CompetitionTask2\\Extent Reports\\Certification.html");
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
            loginObj = new Login();
            loginObj.LoginActions();
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }
        [TearDown]
        public void TearDown()
        {
            //If tests fails capture screenshot
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                string testName = TestContext.CurrentContext.Test.Name;
                test.Log(Status.Fail, $"Tests  '{testName}' failed");
                CaptureScreenshot(testName);
            }
            // Close the browser after each test
            dr.Quit();
        }
        public bool ContainsSpecialCharacters(string universityName)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(universityName, @"[^a-zA-Z0-9\s]");
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
        string filePath = "C:\\Users\\owner\\OneDrive\\Documents\\Mars-QA\\MarsQA-CompetitionTask2\\MarsQA-CompetitionTask2\\Screenshot";
        string screenshotPath = Path.Combine(filePath, $"{screenshotFileName}_{DateTime.Now:yyyyMMdd_HHmmss}.png");
        screenshot.SaveAsFile(screenshotPath);
    }

}
}