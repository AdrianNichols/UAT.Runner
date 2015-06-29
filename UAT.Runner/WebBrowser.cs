using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WatiN.Core;
using WatiN.Core.Native.Chrome;

namespace UAT.Runner
{
    public static class WebBrowser
    {
        private const string Key = "browser";

        public static Browser Current
        {
            get
            {
                switch (Settings.Default.Browser) {
                    case "FireFox": return FireFoxBrowser;
                    case "IE": return IEBrowser;
                    default: return IEBrowser;
                };
            }
        }

        public static FireFox FireFoxBrowser
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

        public static IE IEBrowser
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
