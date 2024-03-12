﻿using MarsQA_CompetitionTask2.Utilits;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V120.Runtime;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_CompetitionTask2.Pages.Skill
{
    public class Profile : CommonDriver
    {
        string actualMessage;
        string actualMessage1;
        string actualMessage2;
        public IWebElement CertificateTab => dr.FindElement(By.XPath("//a[@data-tab='fourth']"));
        public IWebElement AddNew => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        public IWebElement CertificateName => dr.FindElement(By.Name("certificationName"));
        public IWebElement CertificateForm => dr.FindElement(By.Name("certificationFrom"));
        public SelectElement year => new SelectElement(dr.FindElement(By.Name("certificationYear")));
        public IWebElement Add => dr.FindElement(By.XPath("//input[@value='Add']"));
        public IWebElement messageAlert => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        public IWebElement AlertMessage => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        public IWebElement AlertMessage1 => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        public void AddCertificate()
        {
            Thread.Sleep(1000);
            CertificateTab.Click();
            Thread.Sleep(1000);
            AddNew.Click();
            Thread.Sleep(1000);
            CertificateName.SendKeys("Java Language");
            Thread.Sleep(1000);
            CertificateForm.SendKeys("Adobe");
            Thread.Sleep(1000);
            year.SelectByValue("2017");
            Add.Click();
            Thread.Sleep(1000);
            AddNew.Click();
            Thread.Sleep(2000);
            CertificateName.SendKeys("ISTQB");
            CertificateForm.SendKeys("Adobe");
            Thread.Sleep(1000);
            year.SelectByValue("2018");
            Wait.WaitToExist("XPath", "//input[@value='Add']", 6);
            Add.Click() ;
            Thread.Sleep(1000);
            AddNew.Click();
            CertificateName.SendKeys("Automation testing");
            CertificateForm.SendKeys("Adobe");
            Thread.Sleep(1000);
            year.SelectByValue("2020");
            Wait.WaitToExist("XPath", "//input[@value='Add']", 6);
            Add.Click();

        }
        public string VaditeByAddingDuplicateCertificate()
        {
            Thread.Sleep(3000);
            CertificateTab.Click();
            Thread.Sleep(1000);
            AddNew.Click();
            Thread.Sleep(1000);
            CertificateName.SendKeys("ISTQB");
            CertificateForm.SendKeys("Adobe");
            Thread.Sleep(1000);
            year.SelectByValue("2018");
            Wait.WaitToExist("XPath", "//input[@value='Add']", 6);
            Add.Click();
            //store value of alert
            Thread.Sleep(2000);
            actualMessage = messageAlert.Text;
            Console.WriteLine(actualMessage);
            return actualMessage;

        }
        public string ValidateEmptyScenario()
        {
            Thread.Sleep(1000);
            //Click on Certificate Tab
            CertificateTab.Click();
            Thread.Sleep(1000);
            //Click on Add New Button
            AddNew.Click();
            Thread.Sleep(1000);
            // Click on Add Button
            Add.Click();
            //Store value of alert
            actualMessage1 = AlertMessage.Text;
            Console.WriteLine(actualMessage1);
            return actualMessage1;
        }

        public string ValidateEmptyScenarioByFillingSomeField()
        {
            Thread.Sleep(1000);
            //Click on Certificate Tab
            CertificateTab.Click();
            Thread.Sleep(1000);
            AddNew.Click();
            Thread.Sleep(1000);
            //Fill value in Certificate Name
            CertificateName.SendKeys("CSharp");
            Thread.Sleep(1000);
            //Click on Add Button 
            Add.Click();
            //store value in alert
            actualMessage2 = AlertMessage1.Text;
            Console.WriteLine(actualMessage2);
            return actualMessage2;



        }
    }
}