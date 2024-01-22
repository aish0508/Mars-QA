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
        public IWebElement addLanguage => dr.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
        public IWebElement language => dr.FindElement(By.Name("name"));
        public SelectElement oSelect => new SelectElement(dr.FindElement(By.Name("level")));
        public IWebElement AddButton => dr.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        public IWebElement addLanguage3 => dr.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        public IWebElement language2 => dr.FindElement(By.Name("name"));
        public SelectElement oSelect2 => new SelectElement(dr.FindElement(By.Name("level")));
        public IWebElement AddButton2 => dr.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        public IWebElement SkillsTab => dr.FindElement(By.XPath("//a[normalize-space()='Skills']"));
        public IWebElement addSkills => dr.FindElement(By.XPath("(//div[@class='ui teal button'])[1]"));
        public IWebElement skill => dr.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        public SelectElement selectSkill => new SelectElement(dr.FindElement(By.CssSelector("select[class='ui fluid dropdown']")));
        public IWebElement AddSkillButton => dr.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        public IWebElement languageTab => dr.FindElement(By.XPath("//a[normalize-space()='Languages']"));
        public IWebElement addLanguage4 => dr.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        public IWebElement language1 => dr.FindElement(By.Name("name"));
        public SelectElement oSelect3 => new SelectElement(dr.FindElement(By.Name("level")));
        public IWebElement AddNewButton => dr.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        public IWebElement skillstab => dr.FindElement(By.XPath("//div[@class='ui teal button']"));
        public IWebElement addSkill => dr.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        public IWebElement skill1 => dr.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        public SelectElement selectSkill2 => new SelectElement(dr.FindElement(By.CssSelector("select[class='ui fluid dropdown']")));
        public IWebElement AddSkillButton1 => dr.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));

        public void GoToProfilePage(IWebDriver dr)
        {
            Thread.Sleep(4500);
            //Waits.WaitToBeClickable(dr, "XPath", "addLanguage",35);
            //User adding new language in the profile
            addLanguage.Click();
            //Write language 
            language.SendKeys("Spanish");
            //Select level of language by dropdown
            oSelect.SelectByValue("Basic");
            //Click on Add button to add language in the user profile
            AddButton.Click();
            Thread.Sleep(4500);
            //User adding new language in the profile
            addLanguage3.Click();
            // Adding language  in the profile
            language2.Clear();
            language2.SendKeys("English");
            //Select level of language by dropdown
            oSelect2.SelectByValue("Fluent");
            Thread.Sleep(4500);
            //Click on Add button to add language in the user profile
            AddButton2.Click();
            Thread.Sleep(4500);
            //User Click on Skills tab
            SkillsTab.Click();
            Thread.Sleep(5000);
            //User adding new skill in the profile
            addSkills.Click();
            Thread.Sleep(1000);
            // Add skill in the profile 
            skill.SendKeys("API Testing");
            Thread.Sleep(4000);
            // Select Type of Skills
            selectSkill.SelectByValue("Intermediate");
            Thread.Sleep(4000);
            //Add Skill in the profile
            AddSkillButton.Click();
            //Check you not adding Duplicate Languages 
            Thread.Sleep(5000);
            //Click on language tab
            languageTab.Click();
            Thread.Sleep(3000);
            //User adding new language in the profile
            addLanguage4.Click();
            Thread.Sleep(1000);
            //Adding duplicate language
            Thread.Sleep(3000);
            language1.Clear();
            //writing of language
            language1.SendKeys("Punjabi");
            Thread.Sleep(1000);
            //Selecting type of language 
            oSelect3.SelectByValue("Fluent");

            //Check validation of duplicate Language
            if (language1.Text == "English" || oSelect3.SelectedOption.Text != "Fluent")

            {
                Assert.Fail("The language is already exits in your languages list");

            }
            else
            {
                Thread.Sleep(1000);
                //Click on Add New language button
                AddNewButton.Click();
                Assert.Pass("Punjabi has been added in your language list");
                

            }

        }
    }
}