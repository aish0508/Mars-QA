using Mars_QA.Utilis;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_QA.Pages
{
    public class Delete : CommonDriver
    {
        public IWebElement Langtab => dr.FindElement(By.XPath("//a[contains(text(),'Languages')]"));
        public IWebElement delete => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
        public IWebElement skillsTab => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        public IWebElement deleteIcon =>dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[2]/i"));
        
        public void DeleteOption(IWebDriver dr)
        {
            Thread.Sleep(3000);
            //Click on Language Tab
            Langtab.Click();
            //click on Delete Icon to delete language
            delete.Click();
            // click on Skill tab 
            skillsTab.Click();
            Thread.Sleep(2000);
            // deleting skills
            deleteIcon.Click();

        }
    }
}
