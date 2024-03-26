using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_CompetitionTask2.Utilits
{
    public class CommonDriver
    {
        public static IWebDriver dr;
        public void Initialize()
        {

            //Open Chrome Browser
            dr = new ChromeDriver();
            //Maximize the browser
            dr.Manage().Window.Maximize();
        }
        public void CaptureScreenshot(string ScreenshotName)
        {
            //capture screenshot
            ITakesScreenshot ts = (ITakesScreenshot)dr;
            Screenshot screenshot = ts.GetScreenshot();
            string filePath = "C:\\Users\\owner\\OneDrive\\Documents\\Mars-QA\\MarsQA-CompetitionTask2\\MarsQA-CompetitionTask2\\Screenshot";
            string screenshotPath = Path.Combine(filePath, $"{ScreenshotName}_{DateTime.Now:yyyyMMdd_HHmmss}.png");
            screenshot.SaveAsFile(screenshotPath);
        }
        public bool ContainsSpecialCharacters(string universityName)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(universityName, @"[^a-zA-Z0-9\s]");
        }

        [TearDown]
        public void TearDown()
        {
            // Close the browser after each test
            dr.Close();
        }
    }
}