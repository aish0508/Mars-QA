using AdvancedTaskPart1.Pages.ProfileAboutMe;
using AdvancedTaskPart1.Pages.SignIn;
using AdvancedTaskPart1.Steps;
using AdvancedTaskPart1.Utilits;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Tests
{
    [TestFixture]
    public class ProfileTest:CommonDriver
    {
        Login loginObj;
        ProfileSteps profileSteps;
        public ProfileTest() 
        { 
            loginObj = new Login();
            profileSteps = new ProfileSteps();
            
        }
        [SetUp]
        public void LoginActions()
        {
            loginObj.LoginActions();
            
        }

        [Test, Order(1), Description("This test is updating Availability type in the Profile")]
        [TestCase(1)]
        public void Edit_Availability(int id)
        {
            profileSteps.editAvailability(id);
        }

        [Test, Order(2), Description("This test is cancelling Availability type in the Profile")]
        public void Cancel_Availability()
        {
            profileSteps.cancelAvailability();
        }

        [Test, Order(3), Description("This test is updating Hours in the Profile")]
        [TestCase(2)]
        public void Edit_Hours(int id)
        {
            profileSteps.editHours(id);
        }

        [Test, Order(4), Description("This test is updating EarnTarget in the Profile")]
        [TestCase(3)]
        public void Edit_EarnTarget(int id)
        {
            profileSteps.editEarnTarget(id);
        }
    }
}
