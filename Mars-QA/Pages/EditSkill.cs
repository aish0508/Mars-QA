using Mars_QA.Utilis;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium.Essentials;

namespace Mars_QA.Pages
{
    public class EditSkill:CommonDriver
    {
        public string ActualMessage3;
        public string ActualMessage1;
        public IWebElement SkillTab => dr.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
        public IWebElement EditSkillIcon => dr.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
        public IWebElement SkillInput => dr.FindElement(By.Name("name"));
        public SelectElement oselect5 => new SelectElement(dr.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]")));
        public IWebElement UpdateSkill => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
        public IWebElement Alert2 => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        public IWebElement AlertSkillBox => dr.FindElement(By.XPath("//div[@class='ns-box-inner'][1]"));
        public string EditSkillWithValid(string SkillName, string SkillType)
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
        public string EditSkillWithInvalid(string InvalidSkillName)
        {
            //Check By adding Invalid Input in Skill Field
            SkillTab.Click();
            //Edit skill by clicking on edit icon
            Thread.Sleep(2000);
            EditSkillIcon.Click();
            Thread.Sleep(2000);
            SkillInput.Clear();
            Thread.Sleep(1000);
            //Enter Invalid input in skill name field     
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
