using AdvancedTaskPart1.AssertHelpers;
using AdvancedTaskPart1.Pages.AccountMenu;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Steps
{
    public class NotificationSteps
    {
        Notification notificationObj;
        NotificationOverviewcomponents notificationOverviewcomponents;
        public NotificationSteps()
        {
            notificationObj = new Notification();
            notificationOverviewcomponents = new NotificationOverviewcomponents();
        }
        public void loadMoreNotification()
        {
            notificationOverviewcomponents.GoToNotifications();
            notificationObj.LoadMoreNotification();
            // Retrieve the list of requests after clicking Loadmore button
            List<IWebElement> RequestsList = notificationObj.getRequestsList();
            // Get the count of requests in the request list
            int ActualCount = RequestsList.Count;
            Console.WriteLine(ActualCount);
            // Assert that the actual count of requests is equal to the expected count 
            NotificationAssertHelper.assertLoadMoreNotification(9, ActualCount);
        }

        public void showLessNotification()
        {
            notificationOverviewcomponents.GoToNotifications();
            notificationObj.ShowLessNotification();
            // Retrieve the list of requests after clicking ShowLess button
            List<IWebElement> RequestsList = notificationObj.getRequestsList();
            int ActualCount = RequestsList.Count;
            // Assert that the actual count of requests is equal to the expected count 
            NotificationAssertHelper.assertShowLessNotification(4, ActualCount);
        }

        public void deleteNotification()
        {
            notificationOverviewcomponents.GoToNotifications();
            notificationObj.clickDeleteNotification();
            // Retrieve the message displayed after deleting notification
            string ActualMessage = notificationObj.getMessage();
            NotificationAssertHelper.assertSuccessMessageNotification("Notification updated", ActualMessage);
        }

        public void markAsReadNotification()
        {
            notificationOverviewcomponents.GoToNotifications();
            notificationObj.markAsReadNotification();
            // Retrieve the message displayed after clicking MarkAsRead
            string ActualMessage = notificationObj.getMessage();
            NotificationAssertHelper.assertSuccessMessageNotification("Notification updated", ActualMessage);
        }

        public void selectAllNotification()
        {
            notificationOverviewcomponents.GoToNotifications();
            notificationObj.selectAllNotification();
            // Retrieve a list of checkboxes that are selected on the notification page
            List<IWebElement> CheckBoxSelected = notificationObj.VerifyChechboxSelected();
            // Iterate through each checkbox in the list to verify if they are selected
            foreach (var checkbox in CheckBoxSelected)
            {
                // Assert that the checkbox is selected
                NotificationAssertHelper.assertSelectAllNotification(checkbox.Selected);
            }
        }

        public void UnSelectAllNotification()
        {
            notificationOverviewcomponents.GoToNotifications();
            notificationObj.unSelectAllNotification();
            // Retrieve a list of checkboxes that are unselected on the notification page
            List<IWebElement> CheckBoxUnSelected = notificationObj.VerifyChechboxSelected();
            // Iterate through each checkbox in the list to verify if they are unselected
            foreach (var checkbox in CheckBoxUnSelected)
            {
                // Assert that the checkbox is unselected
                NotificationAssertHelper.assertUnSelectAllNotification(checkbox.Selected);
            }
        }
    }
}
