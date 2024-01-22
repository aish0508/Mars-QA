using Mars_QA.Utilis;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_QA.Pages
{
    public class Edit : CommonDriver
    {
        public IWebElement editicon => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
        public IWebElement EditLangIcon => dr.FindElement(By.XPath("//input[@name='name']"));
        public SelectElement oSelect4 => new SelectElement(dr.FindElement(By.Name("level")));
        public IWebElement Update => dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
        public IWebElement SkillTab => dr.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
        public IWebElement EditSkillIcon => dr.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
        public IWebElement SkillInput => dr.FindElement(By.Name("name"));
        public SelectElement oselect5 => new SelectElement(dr.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]")));
        public IWebElement UpdateSkill => dr.FindElement(By.XPath("//input[@value='Update']"));


        public void EditLang(IWebDriver dr)
        {
            Thread.Sleep(4000);
            //click on edit Icon of language
            editicon.Click();
            //Edit the hindi language with French language
            EditLangIcon.Clear();
            EditLangIcon.SendKeys("French");
            //Select the type of language
            oSelect4.SelectByValue("Basic");
            //Update the edited language
            Update.Click();
            //Click on Skill Tab
            SkillTab.Click();
            // Click on skillIcon
            EditSkillIcon.Click();
            Thread.Sleep(3000);
            //Edit New Skill
            SkillInput.Clear();
            SkillInput.SendKeys("Sanity Testing");
            //Select the new skill type
            oselect5.SelectByValue("Beginner");
            //Update  new skill in the profile
            UpdateSkill.Click();

           
        }
    }
}
