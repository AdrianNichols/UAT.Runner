using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace UAT.Runner
{
    public static class WebBrowser
    {
        private const string Key = "browser";

        public static Browser Current
        {
            get
            {
                return MustFix;
            }
        }

        public static FireFox ShouldFox
        {
            get
            {
                if (!ScenarioContext.Current.ContainsKey(Key))
                {
                    var browser = new FireFox();

                    ScenarioContext.Current[Key] = browser;
                }

                return ScenarioContext.Current[Key] as FireFox;
            }
        }

        public static IE MustFix
        {
            get
            {
                if (!ScenarioContext.Current.ContainsKey(Key))
                {
                    var browser = new IE();

                    ScenarioContext.Current[Key] = browser;
                }

                return ScenarioContext.Current[Key] as IE;
            }
        }
    }
}
