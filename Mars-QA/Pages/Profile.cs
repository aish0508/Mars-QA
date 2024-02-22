using Aspose.Cells.Drawing;
using Mars_QA.Utilis;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        
        public IWebElement addLangButton => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
      //  public IWebElement addLanguage => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        public IWebElement language=> dr.FindElement(By.Name("name"));
        public SelectElement oSelect => new SelectElement(dr.FindElement(By.Name("level")));
        public IWebElement AddButton => dr.FindElement(By.XPath("//input[@value='Add']"));
        //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]
        public IWebElement SkillsTab => dr.FindElement(By.XPath("//a[normalize-space()='Skills']"));
        public IWebElement addSkills => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        public IWebElement skill => dr.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        public SelectElement selectSkill => new SelectElement(dr.FindElement(By.XPath("//select[@class='ui fluid dropdown']")));
        public IWebElement AddSkillButton => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        public IWebElement languageTab => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        public IWebElement addNewLanguageButton => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        //public IWebElement language1 => dr.FindElement(By.Name("name"));
        //public SelectElement oSelect3 => new SelectElement(dr.FindElement(By.Name("level")));
        //public IWebElement AddNewButton => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        //public IWebElement AddNewSkill => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        // public IWebElement AddSkillButton1 => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        // public IWebElement Skill1=> dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
        //public SelectElement selectSkill2 => new SelectElement(dr.FindElement(By.XPath("//select[@name='level']")));
        //public IWebElement AddSkillButton1 => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
      //  public IWebElement Language1 => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
        public SelectElement languageType => new SelectElement(dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")));
        //public IWebElement SkillName => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
        //public SelectElement SkillType => new SelectElement(dr.FindElement(By.XPath("//*[@id=account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")));
         public IWebElement messageBox => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        public IWebElement skillmessagebox => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        public IWebElement Cancel => dr.FindElement(By.XPath("//input[@value='Cancel']"));


        public void AddLanguageAndSkill(string LanguageName, string LanguageType, string SkillName, string SkillType)
        {

            //Validate Empty Scenario by adding new language without filling fields
            Thread.Sleep(3000);
            addLangButton.Click();
            Thread.Sleep(5000);
            AddButton.Click();
            Thread.Sleep(4000);
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
            AddSkillButton.Click();
            Thread.Sleep(3000);
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
        public string AssertByAddingDuplicateLanguage(string LanguageName, string LanguageType)
        {
            //Check you not adding Duplicate Languages
            Thread.Sleep(5000);
            //Click on language tab
            languageTab.Click();
           // addNewLanguageButton.Click() ;
            Thread.Sleep(3000);
            //Adding duplicate language
            language.Clear();
             Thread.Sleep(3000);
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
            Thread.Sleep(1000);
            Console.WriteLine(actualMessage);
            return actualMessage;
            
        }
        public string AssertByAddingDuplicateSkill(string SkillName, string SkillType)
        {
            //Validating duplicate skill scenario
            Thread.Sleep(2000);
            SkillsTab.Click();
          //  Thread.Sleep(2000);
          //  addSkills.Click();
            Thread.Sleep(5000);
          AddSkillButton.Click();
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
            actualMessageSkill = skillmessagebox.Text;
            Thread.Sleep(1000);
            Console.WriteLine(actualMessageSkill);
            return actualMessageSkill;
            
            
        }
            
           // Cancel.Click();
            

        }

    }

     
