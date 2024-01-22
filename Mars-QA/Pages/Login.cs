using Mars_QA.Utilis;using OpenQA.Selenium;using OpenQA.Selenium.Support.UI;using System;using System.Collections.Generic;using System.Linq;using System.Security.Cryptography.X509Certificates;using System.Text;using System.Threading.Tasks;using System.Xml.Serialization;namespace Mars_QA.Pages{    public class Login : CommonDriver             {        public IWebElement SignIn=> dr.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));        public IWebElement Email => dr.FindElement(By.Name("email"));        public IWebElement Password => dr.FindElement(By.Name("password"));        public IWebElement LoginButton => dr.FindElement(By.XPath("//button[normalize-space()='Login']"));        public void LoginActions (IWebDriver dr)
        {            
         //navigate to website url
            dr.Navigate().GoToUrl("http://localhost:5000");            //click on Signin button            SignIn.Click();
            Thread.Sleep(2000);
           // Waits.WaitToBeClickable(dr, "Name", "Email", 60);
            //user write email address
            Email.SendKeys("aisharya994@gmail.com");                        //user write password            Password.SendKeys("Aish@123");            //User click on login button             LoginButton.Click();        }            }}