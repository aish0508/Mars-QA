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
    public class SearchSkillTest : CommonDriver
    {
        Login loginObj;
        SearchSkillSteps searchSkillSteps;

        public SearchSkillTest()
        {
            loginObj = new Login();
            searchSkillSteps = new SearchSkillSteps();
        }
        [SetUp]
        public void Login()
        {
            loginObj.LoginActions();
        }

        [Test, Order(1), Description("This test is returning the skills by category")]
        public void SearchSkills_Category()
        {
            searchSkillSteps.searchSkillCategory();
        }

        [Test, Order(2), Description("This test is returning the skills by filters")]
        public void SearchSkills_Filters()
        {
            searchSkillSteps.searchSkillFilters();
        }
    }

}
