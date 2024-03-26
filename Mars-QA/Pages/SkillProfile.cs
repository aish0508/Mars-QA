using Aspose.Cells.Drawing;
using Mars_QA.Utilis;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
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
    public class SkillProfile : CommonDriver
    {
        string actualMessage2;
        string actualMessageSkill;
      // public IWebElement skillsTab => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        public IWebElement addSkills => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        public IWebElement skill => dr.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        public SelectElement selectSkill => new SelectElement(dr.FindElement(By.XPath("//select[@class='ui fluid dropdown']")));
        public IWebElement AddSkillButton => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        public IWebElement message => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        public IWebElement skillmessagebox => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));

        public void DeleteAllRecords()
        {


            Thread.Sleep(6000);
            //skillsTab.Click();
          //  Waits.WaitToExist("XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody", 7);
            // deleting skills
            int rowcount = dr.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody")).Count;
            for (int i = 1; i <= rowcount;)
            {
                Thread.Sleep(7000);
                //Waits.WaitToExist("XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i",5);
                IWebElement DeleteButton1 = dr.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
                Thread.Sleep(6000);
                DeleteButton1.Click();
                rowcount--;
                //driver.Navigate().Refresh();
                
            }
        }

            public void AddSkills(string SkillName, string SkillType)
            {
                //User Click on Skills tab
                Waits.WaitToExist("XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 5);
                addSkills.Click();
            //User adding new skill in the profile
                Waits.WaitToExist("XPath", "//input[@placeholder='Add Skill']", 5);
            // Add skill in the profile 
                skill.SendKeys(SkillName);
                Thread.Sleep(4000);
                // Select Type of Skills
                selectSkill.SelectByValue(SkillType);
                Thread.Sleep(2000);
                //Add Skill in the profile
                AddSkillButton.Click();
            }

            public string EmptyScenarioofSkill(string SkillName, string SkillType)
            {
                Thread.Sleep(1000);
                //Click on Skill Tab
              //  skillsTab.Click();
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

            public string AssertByAddingDuplicateSkill(string SkillName, string SkillType)
            {
                //Validating duplicate skill scenario
                Thread.Sleep(2000);
              //  skillsTab.Click();
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
                actualMessageSkill = skillmessagebox.Text;
                Thread.Sleep(1000);
                Console.WriteLine(SkillMessage);
                return actualMessageSkill;


            }
            public string SkillMessage(string SkillMessage)
            {
                if (actualMessageSkill == SkillMessage)
                {
                    Console.WriteLine(SkillMessage);
                }
                return SkillMessage;
            }

        }
    }


