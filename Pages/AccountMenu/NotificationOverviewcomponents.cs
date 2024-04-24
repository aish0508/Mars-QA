using AdvancedTaskPart1.Utilits;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Pages.AccountMenu
{
    public class NotificationOverviewcomponents:CommonDriver
    {
        private IWebElement NotificationDropdown;
        private IWebElement SeeAllLink;

        public void renderNotificationDropdown()
        {
            try
            {
                Wait.WaitToBeClickable(dr, "XPath", "//div[@class='ui top left pointing dropdown item']", 4);
                NotificationDropdown = dr.FindElement(By.XPath("//div[@class='ui top left pointing dropdown item']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderSeeAllNotificationLink()
        {
            try
            {
                Wait.WaitToBeClickable(dr, "XPath", "//a[text()='See All...']", 6);
                SeeAllLink = dr.FindElement(By.XPath("//a[text()='See All...']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void GoToNotifications()
        {
            renderNotificationDropdown();
            NotificationDropdown.Click();
            renderSeeAllNotificationLink();
            SeeAllLink.Click();
        }
    }
}

