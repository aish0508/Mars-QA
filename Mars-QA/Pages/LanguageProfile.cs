using Aspose.Cells.Drawing;
using Mars_QA.Utilis;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Essentials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_QA.Pages
{
    public class LanguageProfile : CommonDriver
    {
        string actualMessage;
        string actualMessage1;
       
        public IWebElement addLangButton => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        public IWebElement language=> dr.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        public SelectElement oSelect => new SelectElement(dr.FindElement(By.Name("level")));
        public IWebElement AddButton => dr.FindElement(By.XPath("//input[@value='Add']"));
       
      //  public IWebElement SkillsTab => dr.FindElement(By.XPath("//a[normalize-space()='Skills']"));
        public IWebElement languageTab => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        public IWebElement addNewLanguageButton => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        public SelectElement languageType => new SelectElement(dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")));
        public IWebElement messageBox => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
       
        // public IWebElement Cancel => dr.FindElement(By.XPath("//input[@value='Cancel']"));
        // public  IWebElement Hindi => dr.FindElement(By.XPath("//td[normalize-space()='Hindi']")); 
        public IWebElement messageBox1 => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));

        public void DeleteAllRecords()
        {

            Waits.WaitToExist("XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 5);
            //Click on Language Tab
            languageTab.Click();
            //click on Delete Icon to delete languages
            //Get the count of rows in the table
            int rowcount = dr.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table//tbody")).Count;
            for (int i = 1; i <= rowcount;)
            {
                IWebElement DeleteButton = dr.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
                DeleteButton.Click();
                rowcount--;
                //driver.Navigate().Refresh();
                //Thread.Sleep(5000);
            }
        }


            public void AddLanguage(string LanguageName, string LanguageType)
        {

            //Validate Empty Scenario by adding new language without filling fields
            //Thread.Sleep(3000);
            Waits.WaitToExist("XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 5);
            addLangButton.Click();
            Waits.WaitToExist("XPath", "//input[@placeholder='Add Language']", 5);
            Thread.Sleep(5000);
            //Waits.WaitToBeClickable(dr, "XPath", "addLanguage",35);
            //User adding new language in the profile
            //addLangButton.Click() ;
           //Write language 
            language.SendKeys(LanguageName);
            //Select level of language by dropdown
            oSelect.SelectByValue(LanguageType);
            //Click on Add button to add language in the user profile
            AddButton.Click();
                                  

        }
        public string EmptyScenario(string LanguageName, string LanguageType)
        {
            //Click on Language tab
            Waits.WaitToExist("XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 4);
            languageTab.Click();
            Waits.WaitToExist("XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 4);
            addLangButton.Click();
            Waits.WaitToExist("XPath", "//input[@placeholder='Add Language']", 1);
            Thread.Sleep(1000);
            //Enter empty Language Textbox
            language.SendKeys(LanguageName);
            Thread.Sleep(1000);
            //Enter Level language
            oSelect.SelectByValue(LanguageType);
            Thread.Sleep(1000);
            //Click on Add 
            AddButton.Click();
            Thread.Sleep(1000);
            // Getting Empty Scenario alert message of language
            Thread.Sleep(1000);
            actualMessage1 = messageBox1.Text;
            Thread.Sleep(1000);
            Console.WriteLine(actualMessage1);
            return actualMessage1;
        }
           
                       
        public string AssertByAddingDuplicateLanguage(string LanguageName, string LanguageType)
        {
            //Check you not adding Duplicate Languages
            Thread.Sleep(5000);
            //Click on language tab
            languageTab.Click();
            Thread.Sleep(2000);
            addLangButton.Click();
            // addNewLanguageButton.Click() ;
            Thread.Sleep(3000);
            //Adding duplicate language
            language.Clear();
            Thread.Sleep(5000);
            //writing of language
            language.SendKeys(LanguageName);
            Thread.Sleep(1000);
            //Selecting type of language 
            oSelect.SelectByValue(LanguageType);
            //validate by adding duplicate language                     
            Thread.Sleep(4000);
            //Click on Add New language button
            AddButton.Click();
            // Thread.Sleep(1000);
            //Cancel.Click();

            Thread.Sleep(1000);
            actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            return actualMessage;
           
           
            
        }
        public string Message(string LanguageMessage)
        {
            if (actualMessage == LanguageMessage)
            {
                Console.WriteLine(LanguageMessage);
            }

                return LanguageMessage;
        }
       
        }

    }

     
