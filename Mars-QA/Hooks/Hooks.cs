using Mars_QA.Utilis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Mars_QA.Hooks
{
    public  sealed class Hooks: CommonDriver
    {
        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            Initialize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            TearDown();
        }
    }
}
