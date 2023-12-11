using Mars_QA.Utilis;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Mars_QA.Pages
{
    public class Login 
    {
        public void LoginActions(IWebDriver dr)
        {
            dr.Manage().Window.Maximize();
            //navigate to website url
            dr.Navigate().GoToUrl("http://localhost:5000/Home");
            //click on Signin button
            IWebElement SignIn = dr.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            SignIn.Click();
            Waits.WaitToExist(dr, "Id", "Email", 8);
            // find element of email
            IWebElement Email=dr.FindElement(By.Name("email"));
            //user write email address
            Email.SendKeys("aisharya994@gmail.com");
            //find element of password field
            IWebElement Password = dr.FindElement(By.Name("password"));
            //user write password
            Password.SendKeys("Aish@123");
            //User click on login button 
            IWebElement Login = dr.FindElement(By.XPath("//*/div[4]/div/div/div[1]/div/div[4]/button"));
            Login.Click();
        }
        
    }
}
