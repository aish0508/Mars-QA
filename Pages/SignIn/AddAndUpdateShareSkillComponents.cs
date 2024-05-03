using AdvancedTaskPart1.Model;
using AdvancedTaskPart1.Utilits;
using Aspose.Cells;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Pages.SignIn
{
    public class AddAndUpdateShareSkillComponents:CommonDriver
    {
        private IWebElement Title;
        private IWebElement Description;
        private IWebElement Category;
        private IWebElement Tags;
        private IWebElement ServiceType;
        private IWebElement LocationType;
        private IWebElement StartDate;
        private IWebElement EndDate;
        private IWebElement SkillTrade;
        private IWebElement SkillExchange;
        private IWebElement Active;
        private IWebElement SaveButton;
        private IWebElement newTitle;
        private IWebElement CategoryDropdown;
        private IWebElement SubcategoryDropdown;
       // private IWebElement Credit;
        private IWebElement successMessage;

      public void renderAddComponents()
        {
            try 
            { 
                Title = dr.FindElement(By.Name("title")); 
                Description= dr.FindElement(By.Name("description"));
                Tags = dr.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div[1]/div/div/div/input"));
                ServiceType = dr.FindElement(By.Name("serviceType"));
                LocationType = dr.FindElement(By.Name("locationType"));
                StartDate = dr.FindElement(By.XPath("//input[@placeholder='Start date']"));
                EndDate = dr.FindElement(By.XPath("//input[@placeholder='End date']"));
                SkillTrade = dr.FindElement(By.Name("skillTrades"));
                SkillExchange = dr.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
                Active = dr.FindElement(By.Name("isActive"));
                SaveButton = dr.FindElement(By.XPath("//input[@value='Save']"));
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex);
            }    
      }
        public void renderTitle(string title)
        {
            try
            {
                newTitle=dr.FindElement(By.XPath($"//td[@class='four wide'][text()='{title}'][1]"));
            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex);
            }
        }
        public void renderCategory()
        {
            try
            {
                Wait.WaitToBeClickable(dr, "XPath", "//select[@name='categoryId']", 4);
                CategoryDropdown = dr.FindElement(By.XPath("//select[@name='categoryId']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderSubcategory()
        {
            try
            {
                SubcategoryDropdown = dr.FindElement(By.XPath("//select[@name='subcategoryId']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //public void renderCredit()
        //{
        //    try
        //    {
        //        Credit = dr.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input"));
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //    }
        //}
        public void renderUpdateComponent()
        {
            try
            {
                Wait.WaitToBeVisible(dr, "XPath", "//input[@name='title']", 10);
                Title = dr.FindElement(By.XPath("//input[@name='title']"));
                Description = dr.FindElement(By.Name("description"));
                StartDate = dr.FindElement(By.XPath("//input[@placeholder='Start date']"));
                EndDate = dr.FindElement(By.XPath("//input[@placeholder='End date']"));
                SaveButton = dr.FindElement(By.XPath("//input[@value='Save']"));

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderMessage()
        {
            try
            {
                Wait.WaitToBeVisible(dr, "XPath", "//div[@class='ns-box-inner']", 4);
                successMessage = dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void addShareSkills(ShareSkillData shareSkillData)
        {
            renderAddComponents();
            Thread.Sleep(4000);
            Title.SendKeys(shareSkillData.Title);
            Description.SendKeys(shareSkillData.Description);
            renderCategory();
            SelectElement chooseCategory = new SelectElement(CategoryDropdown);
            chooseCategory.SelectByText(shareSkillData.Category);
            renderSubcategory();
            SelectElement chooseSubCategory = new SelectElement(SubcategoryDropdown);
            chooseSubCategory.SelectByText(shareSkillData.Subcategory);
            Tags.SendKeys(shareSkillData.Tags);
            Tags.SendKeys(Keys.Enter);
            ServiceType.SendKeys(shareSkillData.ServiceType);
            LocationType.SendKeys(shareSkillData.LocationType);
            StartDate.SendKeys(shareSkillData.StartDate);
            EndDate.SendKeys(shareSkillData.EndDate);
            SkillTrade.SendKeys(shareSkillData.SkillTrade);
            //renderCredit();
            //Thread.Sleep(3000);
            //Credit.SendKeys(shareSkillData.Credit);
            Thread.Sleep(1000);
            SkillExchange.SendKeys(shareSkillData.ShareExchange);
            SkillExchange.SendKeys(Keys.Enter);
            Active.Click();
            SaveButton.Click();
        }
        public string getTitle(string title)
        {
            Thread.Sleep(6000);
            renderTitle(title);
            Thread.Sleep(2000);
            return newTitle.Text;
        }

        public void updateShareSkill(ShareSkillData shareSkillData)
        {
            renderUpdateComponent();
            Thread.Sleep(5000);
            Title.Clear();
            Thread.Sleep(3000);
            Title.SendKeys(shareSkillData.Title);
            Thread.Sleep(3000);
            Description.Clear();
            Thread.Sleep(3000);
            Description.SendKeys(shareSkillData.Description);
            Thread.Sleep(3000);
            StartDate.SendKeys(shareSkillData.StartDate);
            Thread.Sleep(3000);
            EndDate.SendKeys(shareSkillData.EndDate);
            Thread.Sleep(3000);
            SaveButton.Click();
        }

        public string getMessage()
        {
            renderMessage();
            return successMessage.Text;
        }

    }
}
