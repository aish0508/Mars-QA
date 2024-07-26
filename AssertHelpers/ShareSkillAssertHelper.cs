﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.AssertHelpers
{
    public class ShareSkillAssertHelper
    {
        public static void assertAddShareSkillSuccessMessage(String expected, String actual)
        {
            Assert.That(expected == actual, "Actual message and expected message do not match");
        }

        public static void assertUpdateShareSkillSuccessMessage(String expected, String actual)
        {
            Assert.That(expected == actual, "Actual message and expected message do not match");
        }

        public static void assertDeleteShareSkillSuccessMessage(String expected, String actual)
        {
            Assert.That(expected == actual, "Actual message and expected message do not match");
        }
    }
}
