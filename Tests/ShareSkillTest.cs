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
    public class ShareSkillTest:CommonDriver
    {
        Login loginObj;
        ShareSkillSteps shareSkillSteps;
        public  ShareSkillTest()
        {
            loginObj = new Login();
            shareSkillSteps= new ShareSkillSteps();
        }
        [SetUp]
        public void Login()
        {
            loginObj.LoginActions();
        }
        [Test, Order(1), Description("This test is adding shareskill in the shareskill list")]
        [TestCase(1)]
        public void Add_ShareSkill(int id)
        {
            shareSkillSteps.addShareSkill(id);
        }

        [Test, Order(2), Description("This test is updating an existing shareskill in the shareskill list")]
        [TestCase(2)]
        public void Update_ShareSkill(int id)
        {
            shareSkillSteps.updateShareSkill(id);
        }

        [Test, Order(3), Description("This test is deleting an existing shareskill in the shareskill list")]
        [TestCase(2)]
        public void Delete_ShareSkill(int id)
        {
            shareSkillSteps.deleteShareSkill(id);
        }
    }
}
