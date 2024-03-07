using Mars_QA.Utilis;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mars_QA.Pages
{
    public class HomePage : CommonDriver
    {
       
       
        public void GoToSkillsPage()
        {

            //Thread.Sleep(5000);
            Waits.WaitToExist("XPath", "//a[@data-tab='second']", 5);
            IWebElement skillsTab = dr.FindElement(By.XPath("//a[@data-tab='second']"));
            skillsTab.Click();
        }
    }
}
