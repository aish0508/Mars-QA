using MarsQA_CompetitionTask2.Utilits;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_CompetitionTask2.Pages.Skill
{
    public  class Delete : CommonDriver
    {
        public IWebElement CertificateTab => dr.FindElement(By.XPath("//a[@data-tab='fourth']"));
        public void DeleteCertificate()
        {
            Thread.Sleep(1000);
            CertificateTab.Click();
            Thread.Sleep(3000);
            //click on Delete Icon to delete languages
            //Get the count of rows in the table
            int rowcount = dr.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody")).Count;
            for (int i = 1; i <= rowcount;)

            {
                Thread.Sleep(3000);
                IWebElement delete = dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[4]/span[2]"));
                Thread.Sleep(1000);
                delete.Click();
                rowcount--;
                Thread.Sleep(5000);

            }
        }

    }
}
