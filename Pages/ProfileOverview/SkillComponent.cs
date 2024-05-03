using AdvancedTaskPart1.Model;
using AdvancedTaskPart1.Utilits;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Pages.ProfileOverview
{
    public class SkillComponent : CommonDriver
    {
        private IWebElement deleteButtons;
        private IWebElement skillTextBox;
        private IWebElement skillLevel;
        private IWebElement addButton;
        private IWebElement sucessMessageAlert;
        private IWebElement closeMessageIcon;
        private IWebElement updateButton;
        public void renderDeleteAllRecordsComponent()
        {
            try
            {
               deleteButtons= dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
                               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderAddComponent()
        {
            try
            {
                skillTextBox = dr.FindElement(By.Name("name"));
                skillLevel = dr.FindElement(By.XPath("//select[@name='level']"));
                addButton = dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderAddMessage()
        {
            try
            {
                sucessMessageAlert = dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
                closeMessageIcon = dr.FindElement(By.XPath("//*[@class='ns-close']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderUpdateComponent()
        {
            try
            {
                skillTextBox = dr.FindElement(By.XPath("//input[@name='name']"));
                Wait.WaitToBeClickable(dr, "XPath", "//select[@name='level']", 12);
                skillLevel = dr.FindElement(By.XPath("//select[@name='level']"));
                updateButton = dr.FindElement(By.XPath("//input[@value='Update']"));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex); 
            }
        }
        public void DeleteAllRecords()
        {
           //  renderDeleteAllRecordsComponent();
            //Delete all records in the list
            int rowcount = dr.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody")).Count;
            for (int i = 1; i <= rowcount;)

            {
                Thread.Sleep(3000);
                renderDeleteAllRecordsComponent();
                Thread.Sleep(1000);
                deleteButtons.Click();
                Thread.Sleep(1000);
                rowcount--;
                Thread.Sleep(5000);

            }
        }
        public void AddSkillsComponent(SkillData skillData)
        {
            renderAddComponent();
            skillTextBox.SendKeys(skillData.Skill);
            Thread.Sleep(3000);
            SelectElement chooseSkillLevel = new SelectElement(skillLevel);
            Thread.Sleep(3000);
            chooseSkillLevel.SelectByValue(skillData.SkillLevel);
            Thread.Sleep(3000);
            addButton.Click();
            Wait.WaitToBeVisible(dr, "XPath", "//div[@class='ns-box-inner']", 4);

        }
        public string getMesssage()
        {
            Thread.Sleep(1000);
            renderAddMessage();
            Thread.Sleep(1000);
            string message = sucessMessageAlert.Text;
            closeMessageIcon.Click();
            Thread.Sleep(5000);
            return message;
        }
        public void updateSkill(SkillData skillData)
        {
            renderUpdateComponent();
            Thread.Sleep(1000);
            skillTextBox.Clear();
            Thread.Sleep(1000);
            skillTextBox.SendKeys(skillData.Skill);
            Wait.WaitToBeClickable(dr, "Xpath", "//select[@name='level']", 10);
            SelectElement SkillLevel = new SelectElement(skillLevel);
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(dr, "XPath", "//select[@name='level']", 12);
            SkillLevel.SelectByValue(skillData.SkillLevel);
            Thread.Sleep(3000);
            updateButton.Click();
            Wait.WaitToBeVisible(dr, "XPath", "//div[@class='ns-box-inner']", 4);
        }
    }
}
