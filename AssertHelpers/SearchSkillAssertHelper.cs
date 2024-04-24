using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.AssertHelpers
{
    public class SearchSkillAssertHelper
    {
        public static void assertSkillListNotEmpty(bool skillDisplayed)
        {
            Assert.That(skillDisplayed, Is.True, "Skill list is empty");
        }

        public static void assertSkillListEmpty(List<IWebElement> skillList)
        {
            Assert.That(skillList, Is.Empty, "Skill list is not empty");
        }
    }
}
