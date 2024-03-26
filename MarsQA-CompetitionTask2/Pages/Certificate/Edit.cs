using MarsQA_CompetitionTask2.Utilits;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQA_CompetitionTask2.Data;
using TestAny.Essentials.Core.Dtos.Api;

namespace MarsQA_CompetitionTask2.Pages.Skill
{
    public class Edit:CommonDriver
    {
        string actualMessage;
        public IWebElement CertificateTab => dr.FindElement(By.XPath("//a[@data-tab='fourth']"));
        public IWebElement EditIcon => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[4]/span[1]/i"));
        public IWebElement CertificateName => dr.FindElement(By.Name("certificationName"));
        public IWebElement CertificateForm => dr.FindElement(By.Name("certificationFrom"));
        public SelectElement year => new SelectElement(dr.FindElement(By.Name("certificationYear")));
        public IWebElement Add => dr.FindElement(By.XPath("//input[@class='ui teal button']"));
        public IWebElement Alertmessage => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        public void EditCertificate(CertificationData certifationData)
        {
            Thread.Sleep(3000);
            CertificateTab.Click();
            Thread.Sleep(1000);
            EditIcon.Click();
            Thread.Sleep(1000);
            CertificateName.Clear();
            CertificateName.SendKeys(certifationData.Certificate);
            CertificateForm.Clear();
            CertificateForm.SendKeys(certifationData.CertifiedFrom);
            Thread.Sleep(1000);
            year.SelectByValue(certifationData.Year);
            Thread.Sleep(3000);
            Add.Click();
            
    }
        public string EditCertificateWithInvalidInput(CertificationData certificationData)
        {
            Thread.Sleep(4000);
            CertificateTab.Click();
            Thread.Sleep(1000);
            EditIcon.Click();
            Thread.Sleep(1000);
            CertificateName.Clear();
            Thread.Sleep(4000);
            CertificateName.SendKeys(certificationData.Certificate);
            Thread.Sleep(1000);
            CertificateForm.Clear();
            CertificateForm.SendKeys(certificationData.CertifiedFrom);
            Thread.Sleep(3000);
            Add.Click();
            //storing value of alertmessage
            Thread.Sleep(1000);
            actualMessage = Alertmessage.Text; 
            Console.WriteLine(actualMessage);
            Thread.Sleep(1000);
            return actualMessage;
        }
    }
}
