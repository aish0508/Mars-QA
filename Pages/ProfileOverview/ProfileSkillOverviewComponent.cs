using AdvancedTaskPart1.Model;
using AdvancedTaskPart1.Utilits;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Pages.ProfileOverview
{
    public class ProfileSkillOverviewComponent:CommonDriver
    {
       private IWebElement addNewButton;
       private IWebElement UpdateButton;
       private IWebElement DeleteButton;
        public void renderAddButton()
        {
            try
        { 

            addNewButton = dr.FindElement(By.XPath("//div[@class='ui teal button']"));
        }
            catch(Exception ex) 
        {
                Console.WriteLine(ex);

        }
        }
        public void renderUpdateButton(string existingSkill, string existingSkillLevel)
        {
            try
            {
                UpdateButton = dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderDeleteButton(string skill, string skillLevel)
        {
            try
            {
                DeleteButton = dr.FindElement(By.XPath($"//div[@data-tab='second']//tr[td[1]='{skill}' and td[2]='{skillLevel}']//td[last()]/span[2]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void clickAddSkillButton()
        {
            renderAddButton();
            addNewButton.Click();
        }
        public void clickUpdateSkillButton(SkillData skillData)
        {
            string NewSkill = skillData.Skill;
            string NewSkilllevel=skillData.SkillLevel;
            Thread.Sleep(1000);
            renderUpdateButton(NewSkill, NewSkilllevel);
            UpdateButton.Click();
        }
        public void clickDeleteSkillButton(SkillData skillData)
        {
            string skill = skillData.Skill;
            string skillLevel =skillData.SkillLevel;
            Thread.Sleep(1000);
            renderDeleteButton(skill, skillLevel);
            DeleteButton.Click();
            Wait.WaitToBeVisible(dr, "XPath", "//div[@class='ns-box-inner']", 4);

        }


    }
}
