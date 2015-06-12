using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UAT.Runner.Hooks
{
    [Binding]
    internal class ScenarioBeforeAndAfter
    {
        [BeforeScenario]
        public static void Before()
        {
            // Runs before each scenario and scenario outline      
        }

        [AfterScenario]
        public static void After()
        {
            WebBrowser.Current.Dispose();
        }
    }
}
