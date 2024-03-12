using MarsQA_CompetitionTask2.Utilits;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_CompetitionTask2.Pages.Education
{
    public class Delete : CommonDriver
    {
        public IWebElement Educationtab => dr.FindElement(By.XPath("//a[@data-tab='third']"));
        public void DeleteEducation()
        {
            Thread.Sleep(4000);
            Educationtab.Click();
            //click on Delete Icon to delete languages
            //Get the count of rows in the table
            int rowcount = dr.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody")).Count;
            for (int i = 1; i <= rowcount;)

            {
                Thread.Sleep(3000);
                IWebElement DeleteButton = dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[2]"));
                Thread.Sleep(1000);
                DeleteButton.Click();
                rowcount--;
                //driver.Navigate().Refresh();
                Thread.Sleep(5000);
            }

        }
    }
}
