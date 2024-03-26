using Mars_QA.Utilis;
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
    public class LanguageEdit : CommonDriver
    {
        public string LanguageType;
        public string StringType;
        public string ActualMessage;
        public string ActualMessage2;
      

        public IWebElement editicon => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
        public IWebElement EditLang => dr.FindElement(By.Name("name"));
        public SelectElement oSelect4 => new SelectElement(dr.FindElement(By.Name("level")));
        public IWebElement Update => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
      
        public IWebElement LangTab => dr.FindElement(By.XPath("//a[normalize-space()='Languages']"));
        public IWebElement Alert1 => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
       
        public IWebElement AlertLang => dr.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]")); 
       

        public string EditLangWithValid(string LanguageName, string LanguageType)
        {

            Thread.Sleep(3000);
            //click on edit Icon of language
            editicon.Click();
            Thread.Sleep(3000);
            //Edit the hindi language with French language
            EditLang.Clear();
            Thread.Sleep(3000);
            EditLang.SendKeys(LanguageName);
            //Select the type of language
            Thread.Sleep(3000);
            oSelect4.SelectByValue(LanguageType);
            //Update the edited language
            Update.Click();
            //Gather locator and text of alert
            Thread.Sleep(2000);
            ActualMessage2 = Alert1.Text();
            Thread.Sleep(1000);
            Console.WriteLine(ActualMessage2);
            Thread.Sleep(1000);
            return ActualMessage2; 
        }
        public string AlertMessageLang(string MessageWithValidLang)
        {
            if (ActualMessage2 == MessageWithValidLang)
            {
                Console.WriteLine(MessageWithValidLang);
            }
            return MessageWithValidLang;
        }
            
            
        
       
       
        public string EditLangWithInvalid(string InvalidLanguageName)
        {
            Thread.Sleep(1000);
            LangTab.Click();
            //Check by adding Invalid Input in Language Field
            Thread.Sleep(3000);
            editicon.Click();
            EditLang.Clear();
            Thread.Sleep(2000);
            EditLang.SendKeys(InvalidLanguageName);
            Thread.Sleep(2000);
            //Select the type of language
            oSelect4.SelectByValue("Basic");
            Update.Click();
            //Gathering text of Invalid language from alert popup
            Thread.Sleep(3000);
            ActualMessage = AlertLang.Text();
            Console.WriteLine(ActualMessage);
            return ActualMessage;

        }
        public string AlertMessageLangWithInvalid(string MessageWithInvalidLang)
        {
            if (ActualMessage == MessageWithInvalidLang)
            {
                Console.WriteLine(MessageWithInvalidLang);
            }
            return MessageWithInvalidLang;
        }
       



    }


}

