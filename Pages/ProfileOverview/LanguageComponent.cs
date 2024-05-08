using AdvancedTaskPart1.Model;
using AdvancedTaskPart1.Utilits;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Pages.ProfileOverview
{
    public class LanguageComponent:CommonDriver
    {
        private IWebElement deleteButtons;
        private IWebElement LanguageTextBox;
        private IWebElement languageLevel;
        private IWebElement AddButton;
        private IWebElement successMessage;
        private IWebElement closeMessageIcon;
        private IWebElement UpdateNewButton;
        public void renderDeleteAllRecordsComponents()
        {
            try
            {

                deleteButtons = dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderAddComponents()
        {
            try
            {
                LanguageTextBox = dr.FindElement(By.Name("name"));
                languageLevel = dr.FindElement(By.XPath("//select[@name='level']"));
                AddButton = dr.FindElement(By.XPath("//input[@value='Add']"));
            } catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void renderAddMessage()
        {
            try
            {
                successMessage = dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
                closeMessageIcon = dr.FindElement(By.XPath("//*[@class='ns-close']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void renderUpdateComponents()
        {
            try
            {
                LanguageTextBox = dr.FindElement(By.Name("name"));
                languageLevel = dr.FindElement(By.XPath("//select[@name='level']"));
                UpdateNewButton = dr.FindElement(By.XPath("//input[@value='Update']"));
            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex);
            }

        }

       

        public void DeleteAllRecords()
        {
            //try
            //{
            //    Wait.WaitToBeClickable(dr, "XPath", "//div[@data-tab='first']//i[@class='remove icon']", 4);
            //}
            //catch (WebDriverTimeoutException e)
            //{
            //    return;
            //}
            //renderDeleteAllRecordsComponents();
            ////Delete all records in the list
            //foreach (IWebElement deleteButton in deleteButtons)


            //{
            //    deleteButton.Click();
            //}
          
            //Delete all records in the list
            int rowcount = dr.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody")).Count;
            for (int i = 1; i <= rowcount;)

            {
                Thread.Sleep(3000);
                renderDeleteAllRecordsComponents();
                //Thread.Sleep(1000);
                try
                {
                    Wait.WaitToBeClickable(dr, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i", 8);
                }
                catch (WebDriverTimeoutException e)
                {
                    return;
                }
                deleteButtons.Click();
                Thread.Sleep(1000);
                rowcount--;
                Thread.Sleep(5000);

            }
        }
        public void addLanguage(LanguageData languageData)
        {
            renderAddComponents();
            Thread.Sleep(2000);
            LanguageTextBox.SendKeys(languageData.Language);
            SelectElement chooseLanguageLevel = new SelectElement(languageLevel);
            chooseLanguageLevel.SelectByValue(languageData.LanguageLevel);
            AddButton.Click();
            Wait.WaitToBeVisible(dr, "XPath", "//div[@class='ns-box-inner']", 4);
        }

        public string getMessage()
        {
            renderAddMessage();
            string message = successMessage.Text;
            closeMessageIcon.Click();
            Thread.Sleep(6000);
            return message;
        }

        public void updateLanguage(LanguageData newLanguageData)
        {
            renderUpdateComponents();
            LanguageTextBox.Clear();
            Thread.Sleep(1000);
            LanguageTextBox.SendKeys(newLanguageData.Language);
            Thread.Sleep(1000);
            SelectElement chooseLanguageLevel = new SelectElement(languageLevel);
            Thread.Sleep(1000);
            chooseLanguageLevel.SelectByValue(newLanguageData.LanguageLevel);
            Thread.Sleep(1000);
            UpdateNewButton.Click();
            Wait.WaitToBeVisible(dr, "XPath", "//div[@class='ns-box-inner']", 4);
        }


    }
}
