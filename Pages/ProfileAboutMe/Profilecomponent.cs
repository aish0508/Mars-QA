using AdvancedTaskPart1.Utilits;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Pages.ProfileAboutMe
{
    public class Profilecomponent : CommonDriver
    {
        private IWebElement EditAvailabilityButton;
        private IWebElement Availability;
        private IWebElement successMessage;
        private IWebElement CancelAvailabilityButton;
        private IWebElement EditHoursButton;
        private IWebElement Hours;
        private IWebElement EditEarnTargetButton;
        private IWebElement EarnTarget;

        public void renderAvailabilityButton()
        {
            try
            {
                Wait.WaitToBeClickable(dr, "XPath", "//div[@class='four wide column']//div[@class='item']//strong[contains(text(),'Availability')]/../following-sibling::div//i[@class='right floated outline small write icon']", 6);
                EditAvailabilityButton = dr.FindElement(By.XPath("//div[@class='four wide column']//div[@class='item']//strong[contains(text(),'Availability')]/../following-sibling::div//i[@class='right floated outline small write icon']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderAvailability()
        {
            try
            {
                Availability = dr.FindElement(By.XPath("//select[@name='availabiltyType']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderSuccessMessage()
        {
            try
            {
                Wait.WaitToExist(dr, "XPath", "//div[@class='ns-box-inner']", 4);
                successMessage = dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderCancelAvailability()
        {
            try
            {
                CancelAvailabilityButton = dr.FindElement(By.XPath("//div[@class='four wide column']//div[@class='item']//strong[contains(text(),'Availability')]/../following-sibling::div//i[@class='remove icon']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderHoursButton()
        {
            try
            {
                Wait.WaitToBeClickable(dr, "XPath", "//div[@class='four wide column']//div[@class='item']//strong[contains(text(),'Hours')]/../following-sibling::div//i[@class='right floated outline small write icon']", 6);
                EditHoursButton = dr.FindElement(By.XPath("//div[@class='four wide column']//div[@class='item']//strong[contains(text(),'Hours')]/../following-sibling::div//i[@class='right floated outline small write icon']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderHours()
        {
            try
            {
                Hours = dr.FindElement(By.XPath("//select[@name='availabiltyHour']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderEarnTargetButton()
        {
            try
            {
                Wait.WaitToBeClickable(dr, "XPath", "//div[@class='four wide column']//div[@class='item']//strong[contains(text(),'Earn Target')]/../following-sibling::div//i[@class='right floated outline small write icon']", 6);
                EditEarnTargetButton = dr.FindElement(By.XPath("//div[@class='four wide column']//div[@class='item']//strong[contains(text(),'Earn Target')]/../following-sibling::div//i[@class='right floated outline small write icon']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderEarnTarget()
        {
            try
            {
                EarnTarget = dr.FindElement(By.XPath("//select[@name='availabiltyTarget']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void editAvailability(string availability)
        {
            renderAvailabilityButton();
            Thread.Sleep(1000);
            EditAvailabilityButton.Click();
            Thread.Sleep(1000);
            renderAvailability();
            SelectElement chooseAvailability = new SelectElement(Availability);
            chooseAvailability.SelectByText(availability);
        }

        public string getMessage()
        {
            renderSuccessMessage();
            return successMessage.Text;
        }

        public void cancelAvailabilityButton()
        {
            renderAvailabilityButton();
            Thread.Sleep(1000);
            EditAvailabilityButton.Click();
            Thread.Sleep(1000);
            renderCancelAvailability();
            CancelAvailabilityButton.Click();
        }

        public void editHours(string hours)
        {
            renderHoursButton();
            Thread.Sleep(1000);
            EditHoursButton.Click();
            Thread.Sleep(1000);
            renderHours();
            Thread.Sleep(1000);
            SelectElement chooseHours = new SelectElement(Hours);
            chooseHours.SelectByText(hours);
        }

        public void editEarnTarget(string earnTarget)
        {
            renderEarnTargetButton();
            Thread.Sleep(1000);
            EditEarnTargetButton.Click();
            Thread.Sleep(1000);
            renderEarnTarget();
            SelectElement chooseEarnTarget = new SelectElement(EarnTarget);
            chooseEarnTarget.SelectByText(earnTarget);
        }
    }
}
    

