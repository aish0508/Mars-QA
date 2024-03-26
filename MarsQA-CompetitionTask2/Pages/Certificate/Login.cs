using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQA_CompetitionTask2.Utilits;
using OpenQA.Selenium;

namespace MarsQA_CompetitionTask2.Pages.Skill
{
    public class Login : CommonDriver
    {
        public IWebElement SignIn => dr.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));

        public IWebElement Email => dr.FindElement(By.Name("email"));
        public IWebElement Password => dr.FindElement(By.Name("password"));
        public IWebElement LoginButton => dr.FindElement(By.XPath("//button[normalize-space()='Login']"));
        public void LoginActions()
        {
            //  Initialize();
            //navigate to website url
            dr.Navigate().GoToUrl("http://localhost:5000");
            //click on Signin button
            SignIn.Click();
            Wait.WaitToExist("Name", "email", 5);
            //user write email address
            Email.SendKeys("aisharya994@gmail.com");
            //user write password
            Password.SendKeys("Aish@123");
            //User click on login button 
            LoginButton.Click();
        }
    }
}
