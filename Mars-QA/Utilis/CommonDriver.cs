using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_QA.Utilis
{
    public class CommonDriver
    {
        public static IWebDriver dr;
        public  void Initialize() {

            //Open Chrome Browser
            dr = new ChromeDriver();
            //Maximize the browser
            dr.Manage().Window.Maximize();
        }


        [TearDown]
        public void TearDown()
        {
            // Close the browser after each test
            dr.Quit();
        }

    }
}
