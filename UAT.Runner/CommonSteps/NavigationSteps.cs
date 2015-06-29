using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UAT.Runner.CommonSteps
{
    [Binding]
    public class NavigationSteps
    {
        [Given(@"I want to navigate to (.*)")]
        public void Given_I_want_to_navigate_to(string pageValue)
        {
            WebBrowser.Current.GoToNoWait(pageValue);
        }

    }
}
