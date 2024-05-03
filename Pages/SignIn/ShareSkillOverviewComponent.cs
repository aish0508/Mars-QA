using AdvancedTaskPart1.Model;
using AdvancedTaskPart1.Utilits;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Pages.SignIn
{
    public class ShareSkillOverviewComponent : CommonDriver
    {
        private IWebElement ShareSkillButton;
        private IWebElement ManageListings;
        private IWebElement UpdateButton;
        private IWebElement DeleteButton;
        private IWebElement YesButton;
        public void renderShareSkill()
        {
            try
            {
                ShareSkillButton = dr.FindElement(By.XPath("//a[text()='Share Skill']"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderManageListing()
        {
            try
            {
                Wait.WaitToBeClickable(dr, "XPath", "//a[text()='Manage Listings']", 4);
                ManageListings = dr.FindElement(By.XPath("//a[text()='Manage Listings']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void renderUpdateButton(string existingTitle)
        {
            try
            {
                Wait.WaitToBeVisible(dr, "XPath", "//td[text()='{existingTitle}']/following-sibling::td/div/button[@class='ui button']/i[@class='outline write icon']", 12);
                UpdateButton = dr.FindElement(By.XPath($"//td[text()='{existingTitle}']/following-sibling::td/div/button[@class='ui button']/i[@class='outline write icon']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderDeleteButton(string title)
        {
            try
            {
                Wait.WaitToBeVisible(dr, "XPath", "//td[text()='{title}']/following-sibling::td/div/button[@class='ui button']/i[@class='remove icon']", 12);
                DeleteButton = dr.FindElement(By.XPath($"//td[text()='{title}']/following-sibling::td/div/button[@class='ui button']/i[@class='remove icon']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderYesButton()
        {
            try
            {
                YesButton = dr.FindElement(By.XPath("//button[@class='ui icon positive right labeled button']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void clickShareButton()
        {
            Thread.Sleep(4000);
            renderShareSkill();
            ShareSkillButton.Click();
        }
        public void clickManageListing()
        {
            Thread.Sleep(1000);
            renderManageListing();
            ManageListings.Click();
        }
        public void clickUpdateButton(ShareSkillData shareskilldata)
        {
            string existingTitle = shareskilldata.ExistingTitle;
            Thread.Sleep(1000);
            renderUpdateButton(existingTitle);
            try
            {
                // Wait for the element to be clickable
                WebDriverWait wait = new WebDriverWait(dr, TimeSpan.FromSeconds(60));
                IWebElement button = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//td[text()='Playwright']/following-sibling::td/div/button[@class='ui button']/i[@class='outline write icon']")));

                // Click the button
                button.Click();
            }
            catch (NoSuchElementException ex)
            {
                // Log the error or handle it appropriately
                Console.WriteLine("Element not found: " + ex.Message);
                // Optionally, rethrow the exception if you want to propagate it further
                throw;
            }
            //UpdateButton.Click();
        }
        public void clickDeleteButton(ShareSkillData shareskilldata)
        {
            string title = shareskilldata.Title;
            Thread.Sleep(4000);
            renderDeleteButton(title);
            Wait.WaitToBeVisible(dr, "XPath", $"//td[text()='{title}']/following-sibling::td/div/button[@class='ui button']/i[@class='remove icon']", 12);
            DeleteButton.Click();
            Thread.Sleep(1000);
            renderYesButton();
            YesButton.Click();
        }
    }
}
