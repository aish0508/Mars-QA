using AdvancedTaskPart1.Model;
using AdvancedTaskPart1.Utilits;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Pages.ProfileOverview
{

    public class ProfileLanguageOverviewComponent : CommonDriver
    {
        private IWebElement AddNewButton;
        private IWebElement UpdateButton;
        private IWebElement DeleteButton;

        public void renderAddButton()
        {
            try
            {
                AddNewButton = dr.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void renderUpdateButton(string existingLanguage , string existingLanguageLevel)
        {
            try
            {
                UpdateButton = dr.FindElement(By.XPath($"//div[@data-tab='first']//tr[td[1]='{existingLanguage}' and td[2]='{existingLanguageLevel}']//td[last()]/span[1]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderDeleteButton(string language, string languageLevel)
        {
            try
            {
                DeleteButton = dr.FindElement(By.XPath($"//div[@data-tab='first']//tr[td[1]='{language}' and td[2]='{languageLevel}']//td[last()]/span[2]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void clickAddLanguageButton()
        {
            //Thread.Sleep(11000);
            renderAddButton();
           // Thread.Sleep(3000);
            AddNewButton.Click();
        }

        public void clickUpdateLanguageButton(LanguageData existingLanguageData)
        {
            string existingLanguage = existingLanguageData.Language;
            string existingLanguageLevel = existingLanguageData.LanguageLevel;
            Wait.WaitToBeVisible(dr, "XPath", $"//div[@data-tab='first']//tr[td[1]='{existingLanguage}' and td[2]='{existingLanguageLevel}']//td[last()]/span[1]", 7);
            renderUpdateButton(existingLanguage, existingLanguageLevel);
            Thread.Sleep(3000);
            UpdateButton.Click();
        }

        public void clickDeleteLanguageButton(LanguageData languageData)
        {
            string language = languageData.Language;
            string languageLevel = languageData.LanguageLevel;
            Thread.Sleep(4000);
            renderDeleteButton(language, languageLevel);
            DeleteButton.Click();
            Wait.WaitToBeVisible(dr, "XPath", "//div[@class='ns-box-inner']", 4);
        }
    }
}