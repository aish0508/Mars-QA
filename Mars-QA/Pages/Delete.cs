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
        //public IWebElement delete => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr[1]/td[3]/span[2]/i"));
        //public IWebElement delete1 => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr[last()]/td[3]/span[2]/i"));
        //public IWebElement delete2 => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
        public IWebElement skillsTab => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        public IWebElement deleteIcon => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr[1]/td[3]/span[2]/i"));
        public IWebElement deleteIcon1 => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]"));
        public IWebElement deleteIcon2 => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr[last()]/td[3]/span[2]/i"));

        public void DeleteOption()
        {

            Thread.Sleep(3000);
            //Click on Language Tab
            Langtab.Click();
            //click on Delete Icon to delete languages
            //Get the count of rows in the table
            int rowcount = dr.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table//tbody")).Count;
            for (int i = 1; i <= rowcount;)
            {
                IWebElement DeleteButton = dr.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
                DeleteButton.Click();
                rowcount--;
                //driver.Navigate().Refresh();
                Thread.Sleep(5000);
            }


            // click on Skill tab 
            skillsTab.Click();
            Thread.Sleep(5000);
            // deleting skills
            rowcount = dr.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody")).Count;
            for (int i = 1; i <= rowcount;)
            {
                IWebElement DeleteButton1 = dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
                ///*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i
                DeleteButton1.Click();
                rowcount--;
                //driver.Navigate().Refresh();
                Thread.Sleep(5000);
            }
            //deleteIcon.Click();
            //deleteIcon1.Click();
            //deleteIcon2.Click();





        }
    }
}


