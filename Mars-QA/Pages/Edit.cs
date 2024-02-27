﻿using Mars_QA.Utilis;
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
    public class Edit : CommonDriver
    {
        public string LanguageType;
        public string StringType;
        public string ActualMessage;
        public string ActualMessage1;
        public string ActualMessage2;
        public string ActualMessage3;

        public IWebElement editicon => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
        public IWebElement EditLang => dr.FindElement(By.Name("name"));
        public SelectElement oSelect4 => new SelectElement(dr.FindElement(By.Name("level")));
        public IWebElement Update => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
        public IWebElement SkillTab => dr.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
        public IWebElement EditSkillIcon => dr.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
        public IWebElement SkillInput => dr.FindElement(By.Name("name"));
        public SelectElement oselect5 => new SelectElement(dr.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]")));
        public IWebElement UpdateSkill => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
        public IWebElement LangTab => dr.FindElement(By.XPath("//a[normalize-space()='Languages']"));
        public IWebElement Alert1 => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        public IWebElement Alert2 => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        public IWebElement AlertLang => dr.FindElement(By.XPath("//div[@class='ns-box-inner']")); 
        public IWebElement AlertSkillBox => dr.FindElement(By.XPath("//div[@class='ns-box-inner'][1]"));

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
            Thread.Sleep(1000);
            ActualMessage2 = Alert1.Text();
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
        public string EditSkillWithValid(string SkillName,string SkillType)
        {
            //Click on Skill Tab
            SkillTab.Click();
            // Click on skillIcon
            EditSkillIcon.Click();
            Thread.Sleep(3000);
            //Edit New Skill
            SkillInput.Clear();
            SkillInput.SendKeys(SkillName);
            Thread.Sleep(3000);
            //Select the new skill type
            oselect5.SelectByValue(SkillType);
            //Update  new skill in the profile
            Thread.Sleep(3000);
            UpdateSkill.Click();
            Thread.Sleep(2000);
            //Gather locator and text of alert
            ActualMessage3 = Alert2.Text();
            Console.WriteLine(ActualMessage3);
            Thread.Sleep(1000);
            return ActualMessage3;
        }
            
            
        
        public string AlertMessageSkill(string MessageWithValidSkill)
        {
            if (ActualMessage3 == MessageWithValidSkill)
            {
                Console.WriteLine(MessageWithValidSkill);
            }
            return MessageWithValidSkill;
        }
       
        public string EditLangWithInvalid(string InvalidLanguageName)
        {
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
            //Check By adding Invalid Input in Skill Field
            SkillTab.Click();
            Thread.Sleep(2000);
            //Edit skill by clicking on edit icon
            Thread.Sleep(2000);
            EditSkillIcon.Click();
            Thread.Sleep(2000);
            SkillInput.Clear();
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
        public string EditSkillWithInvalid(string InvalidSkillName)
        {
            Thread.Sleep(1000);
            //Enter Invalid input in skill name field
            SkillInput.Clear();
            Thread.Sleep(1000);
            SkillInput.SendKeys(InvalidSkillName);
            //Enter Invalid input in skill type field
            Thread.Sleep(1000);
            oselect5.SelectByValue("Beginner");
            UpdateSkill.Click();
            //Gathering text of Invalid Skill from alert popup
            Thread.Sleep(2000);
            ActualMessage1 = AlertSkillBox.Text();
            Console.WriteLine(ActualMessage1);
            return ActualMessage1;

        }
        public string AlertMessageSkillWithInvalid(string MessageWithInvalidSkill)
        {
            if (ActualMessage1 == MessageWithInvalidSkill)
            {
                Console.WriteLine(MessageWithInvalidSkill);
            }
            return MessageWithInvalidSkill;
        }



    }


}

