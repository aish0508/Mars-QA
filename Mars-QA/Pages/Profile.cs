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
    public class Profile : CommonDriver
    {
        string actualMessage;
        string actualMessageSkill;
        string actualMessage1;
        string actualMessage2;
        public IWebElement addLangButton => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        public IWebElement language=> dr.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        public SelectElement oSelect => new SelectElement(dr.FindElement(By.Name("level")));
        public IWebElement AddButton => dr.FindElement(By.XPath("//input[@value='Add']"));
       
        public IWebElement SkillsTab => dr.FindElement(By.XPath("//a[normalize-space()='Skills']"));
        public IWebElement addSkills => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        public IWebElement skill => dr.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        public SelectElement selectSkill => new SelectElement(dr.FindElement(By.XPath("//select[@class='ui fluid dropdown']")));
        public IWebElement AddSkillButton => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        public IWebElement languageTab => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        public IWebElement addNewLanguageButton => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        public SelectElement languageType => new SelectElement(dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")));
        public IWebElement messageBox => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        public IWebElement skillmessagebox => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        // public IWebElement Cancel => dr.FindElement(By.XPath("//input[@value='Cancel']"));
        // public  IWebElement Hindi => dr.FindElement(By.XPath("//td[normalize-space()='Hindi']")); 
        public IWebElement messageBox1 => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        public IWebElement message => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));


        public void AddLanguageAndSkill(string LanguageName, string LanguageType, string SkillName, string SkillType)
        {

            //Validate Empty Scenario by adding new language without filling fields
            Thread.Sleep(3000);
            addLangButton.Click();
                 
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
            Thread.Sleep(4500);
            //User Click on Skills tab
            SkillsTab.Click();
            Thread.Sleep(2000);
            //Validate Empty Scenario by directly clicking on add button of skills
            addSkills.Click();
            Thread.Sleep(2000);
            
            //User adding new skill in the profile
            //   addSkills.Click();
            Thread.Sleep(5000);
            // Add skill in the profile 
            skill.SendKeys(SkillName);
            Thread.Sleep(4000);
            // Select Type of Skills
            selectSkill.SelectByValue(SkillType);
            Thread.Sleep(2000);
            //Add Skill in the profile
            AddSkillButton.Click();
            

                




        }
        public string EmptyScenario(string LanguageName, string LanguageType)
        {
            //Click on Language tab
            Thread.Sleep(1000);
            languageTab.Click();
            Thread.Sleep(1000);
            addLangButton.Click();
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
        public string EmptyScenarioofSkill( string SkillName, string SkillType)
        {
            Thread.Sleep(1000);
            //Click on Skill Tab
            SkillsTab.Click();
            // Click on add new button 
            Thread.Sleep(1000);
            addSkills.Click();
            //Enter a skill textbox as empty
            Thread.Sleep(1000);
            skill.SendKeys(SkillName);
            Thread.Sleep(1000);
            //Enter skill level
            selectSkill.SelectByValue(SkillType);
            Thread.Sleep(1000);
            //click on  add skill button
            AddSkillButton.Click();
            //Getting Empty scenario alert message of skill
            Thread.Sleep(1000);
            actualMessage2 = message.Text();
            Thread.Sleep(1000);
            Console.WriteLine(actualMessage2);
            return actualMessage2;
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

            else
            {
                Console.WriteLine("Do not return anything");

            }
            
            return LanguageMessage;
        }
        public string SkillMessage(string SkillMessage)
        {
            if (actualMessageSkill == SkillMessage)
            {
                Console.WriteLine(SkillMessage);
            }

            else
            {
                Console.WriteLine("Do not return anything");
                return ("nothing");
            }
            
            return SkillMessage;
        }

        public string AssertByAddingDuplicateSkill(string SkillName, string SkillType)
        {
            //Validating duplicate skill scenario
            Thread.Sleep(2000);
            SkillsTab.Click();
            Thread.Sleep(2000);
            addSkills.Click();
            Thread.Sleep(3000);
            //User adding new skill in the profile
            skill.Clear();
            // Add skill in the profile 
            skill.SendKeys(SkillName);
            Thread.Sleep(5000);
            // Select Type of Skills
            selectSkill.SelectByValue(SkillType);
            Thread.Sleep(3000);

            //Add Skill in the profile
            AddSkillButton.Click();
            Thread.Sleep(1000);
            actualMessageSkill= skillmessagebox.Text;
            Thread.Sleep(1000);
            Console.WriteLine(SkillMessage);
            return actualMessageSkill;
            
            
        }
            
           // Cancel.Click();
            

        }

    }

     
