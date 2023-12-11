using Mars_QA.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mars_QA.Tests
{
    [TestFixture]
    public class Test
    {
        Login loginObj =new Login();

        [SetUp]
        public void UserProfile()
        {
            IWebDriver dr = new ChromeDriver();
            //Login page object initialization and deifinition
            loginObj.LoginActions(dr);

        }

        [Test, Order(1), Description("This test is creating a new Languages and Skills in user profile")]
        public void Create_Test()
        {
            // Create object initialization and definition

            

        }
    }
}
