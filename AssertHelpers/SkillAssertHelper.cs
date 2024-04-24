using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.AssertHelpers
{
    public class SkillAssertHelper
    {
        public static void assertAddSkillSucessMessage(string expected ,string actual)
        {
            Assert.That(expected == actual, "Actual message and Expected message do not match");
        }
        public static void assertUpdateSkillSucessMessage(string expected, string actual)
        {
            Thread.Sleep(1000);
            Assert.That(expected == actual, "Actual message and Expected message do not match");
        }
        public static void assertEmptySkillSucessMessage(string expected, string actual)
        {
            Assert.That(expected == actual, "Actual message and Expected message do not match");
        }
        public static void assertExitsSkillSucessMessage(string expected , string actual)
        {
            Assert.That(expected == actual, "Actual message and Expected message do not match");
        }
        public static void assertSpecialCharSkillSucessMessage(string expected , string actual)
        {
            Assert.That(expected == actual, "Actual message and Expected message do not match");
        }
        public static void assertDeleteSkillSucessMessage(string expected, string actual)
        {
            Assert.That(expected == actual, "Actual message and Expected message do not match");
        }
    }
}
