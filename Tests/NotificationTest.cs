using AdvancedTaskPart1.Pages.AccountMenu;
using AdvancedTaskPart1.Pages.SignIn;
using AdvancedTaskPart1.Steps;
using AdvancedTaskPart1.Utilits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Tests
{
    [TestFixture]
    public class NotificationTest:CommonDriver
    {
        Login loginObj;
        NotificationSteps notificationSteps;

        public NotificationTest()
    {
        loginObj = new Login();
        notificationSteps = new NotificationSteps();
    }

        [SetUp]
        public void LoginActions()
        {
            loginObj.LoginActions();
        }

        [Test, Order(1), Description("This test is displaying the requests list when click on LoadMore button")]
        public void ShowMore_Notification()
        {
           // notificationSteps.show
        }

        [Test, Order(1), Description("This test is displaying the requests list when click on LoadMore button")]
        public void LoadMore_Notification()
        {
            notificationSteps.loadMoreNotification();
        }

        [Test, Order(2), Description("This test is shrinking the requests list when click on ShowLess button")]
        public void ShowLess_Notification()
        {
            notificationSteps.showLessNotification();
        } 

        [Test, Order(3), Description("This test is marking the requests as read from the notifications list")]
        public void MarkAsRead_Notification()
        {
            notificationSteps.markAsReadNotification();
        }

        [Test, Order(4), Description("This test is selecting all the requests from the notifications list")]
        public void SelectAll_Notification()
        {
            notificationSteps.selectAllNotification();
        }

        [Test, Order(5), Description("This test is unselecting all the requests from the notifications list")]
        public void UnSelectAll_Notification()
        {
            notificationSteps.UnSelectAllNotification();
        }
        [Test, Order(6), Description("This test is deleting the requests from the notifications list")]
        public void Delete_Notification()
        {
            notificationSteps.deleteNotification();
        }

    }
}
