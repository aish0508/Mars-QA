using AdvancedTaskPart1.Utilits;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Pages.AccountMenu
{
    public class Notification : CommonDriver
    {
        private IWebElement LoadMoreButton;
        private IReadOnlyCollection<IWebElement> RequestsList;
        private IWebElement ShowLessButton;
        private IWebElement SelectCheckbox;
        private IWebElement DeleteButton;
        private IWebElement Message;
        private IWebElement MarkSelectionAsRead;
        private IWebElement SelectAllButton;
        private IWebElement UnSelectAllButton;
        private IReadOnlyCollection<IWebElement> CheckBoxSelected;

        public void renderLoadMoreButton()
        {
            try
            {
               // Wait.WaitToBeClickable(dr, "XPath", "//a[@class='ui button']", 8);
               Thread.Sleep(9000);
                LoadMoreButton = dr.FindElement(By.XPath("//a[normalize-space()='Load More...']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderRequestsList()
        {
            try
            {
                RequestsList = dr.FindElements(By.XPath("//div[@class='fourteen wide column']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderShowLessButton()
        {
            try
            {
                // Wait.WaitToBeClickable(dr, "XPath", "//a[text()='...Show Less']", 8);
                Thread.Sleep(8000);
                ShowLessButton = dr.FindElement(By.XPath("//a[text()='...Show Less']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderSelectCheckbox()
        {
            try
            {
                Wait.WaitToBeClickable(dr, "XPath", "(//div[@class='one wide column']/input[@type='checkbox'])[1]", 4);
                SelectCheckbox = dr.FindElement(By.XPath("(//div[@class='one wide column']/input[@type='checkbox'])[1]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderDeleteButton()
        {
            try
            {
                DeleteButton = dr.FindElement(By.XPath("//div[@data-tooltip='Delete selection']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderMessage()
        {
            try
            {
                Wait.WaitToExist(dr, "XPath", "//div[@class='ns-box-inner']", 4);
                Message = dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderMarkAsRead()
        {
            try
            {
                Wait.WaitToBeClickable(dr, "XPath", "//i[@class='check square icon']", 4);
                MarkSelectionAsRead = dr.FindElement(By.XPath("//i[@class='check square icon']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderSelectAll()
        {
            try
            {
                Wait.WaitToBeClickable(dr, "XPath", "//div[@data-tooltip='Select all']", 4);
                SelectAllButton = dr.FindElement(By.XPath("//div[@data-tooltip='Select all']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderUnSelectAll()
        {
            try
            {
                Wait.WaitToBeClickable(dr, "XPath", "//i[@class='ban icon']", 4);
                UnSelectAllButton = dr.FindElement(By.XPath("//i[@class='ban icon']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderVerifyCheckbox()
        {
            try
            {
                Wait.WaitToBeClickable(dr, "XPath", "//input[@type='checkbox']", 4);
                CheckBoxSelected = dr.FindElements(By.XPath("//input[@type='checkbox']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void LoadMoreNotification()
        {
            renderLoadMoreButton();
            LoadMoreButton.Click();
        }

        public List<IWebElement> getRequestsList()
        {
            Thread.Sleep(4000);
            renderRequestsList();
            return new List<IWebElement>(RequestsList);
        }

        public void ShowLessNotification()
        {
            renderLoadMoreButton();
            LoadMoreButton.Click();
            renderShowLessButton();
            ShowLessButton.Click();
        }

        public void clickDeleteNotification()
        {
            renderSelectCheckbox();
            SelectCheckbox.Click();
            renderDeleteButton();
            DeleteButton.Click();
        }

        public string getMessage()
        {
            renderMessage();
            return Message.Text;
        }

        public void markAsReadNotification()
        {
            renderSelectCheckbox();
            SelectCheckbox.Click();
            renderMarkAsRead();
            MarkSelectionAsRead.Click();
        }

        public void selectAllNotification()
        {
            renderSelectAll();
            SelectAllButton.Click();
        }

        public List<IWebElement> VerifyChechboxSelected()
        {
            renderSelectCheckbox();
            if (CheckBoxSelected == null)
            {
                // If SkillList is null, return an empty list
                return new List<IWebElement>();
            }
            return new List<IWebElement>(CheckBoxSelected);
        }

        public void unSelectAllNotification()
        {
            Thread.Sleep(4000);
            renderSelectAll();
            SelectAllButton.Click();
            renderUnSelectAll();
            UnSelectAllButton.Click();
        }
    }
}