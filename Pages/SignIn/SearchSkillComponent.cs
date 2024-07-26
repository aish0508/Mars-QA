using AdvancedTaskPart1.Model;
using AdvancedTaskPart1.Tests;
using AdvancedTaskPart1.Utilits;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Pages.SignIn
{
    public class SearchSkillComponent:CommonDriver
    {
        private IWebElement SearchSkillsButton;
        private IWebElement SearchSkill;
        private IWebElement SelectCategory;
        private IWebElement SelectSubcategory;
        private IReadOnlyCollection <IWebElement>SkillList;
        private IWebElement Message;
        private IWebElement OnlineButton;
        public void renderSearchSkill()
        {
            try
            {
                SearchSkillsButton = dr.FindElement(By.XPath("//input[@placeholder='Search skills']"));
                SearchSkill = dr.FindElement(By.XPath("//i[@class='search link icon']"));
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSearchSkillCategory()
        {
            try
            {
                SelectCategory = dr.FindElement(By.XPath("//a[text()='Programming & Tech']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSearchSkillSubcategory()
        {
            try
            {
                SelectSubcategory = dr.FindElement(By.XPath("//a[text()='QA']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderSkillList()
        {
            try
            {
                SkillList = dr.FindElements(By.XPath("//div[@class='ui card']"));
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
                Message = dr.FindElement(By.XPath("//div[@class='ui grid']/h3"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderSearchSkillFilters()
        {
            try
            {
                OnlineButton = dr.FindElement(By.XPath("//button[text()='Online']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void clickSearchButton(SearchSkillData searchSkillData)
        {
            Wait.WaitToBeClickable(dr, "XPath", "//input[@placeholder='Search skills']", 4);
            renderSearchSkill();
            SearchSkillsButton.Click();
            SearchSkillsButton.SendKeys(searchSkillData.SearchSkill);
            SearchSkill.Click();
        }

        public void SearchSkillCategory()
        {
            Thread.Sleep(4000);
            renderSearchSkillCategory();
            SelectCategory.Click();
        }

        public void SearchSkillSubcategory()
        {
            renderSearchSkillSubcategory();
            SelectSubcategory.Click();
        }

        public List<IWebElement> getSkillList()
        {
            Thread.Sleep(4000);
            renderSkillList();
            if (SkillList == null)
            {
                // If SkillList is null, return an empty list
                return new List<IWebElement>();
            }
            return new List<IWebElement>(SkillList);
        }

        public string getMessage()
        {
            Thread.Sleep(4000);
            renderAddMessage();
            return Message.Text;
        }

        public void SearchSkillFilters()
        {
            Thread.Sleep(4000);
            renderSearchSkillFilters();
            OnlineButton.Click();
        }
    }
}
