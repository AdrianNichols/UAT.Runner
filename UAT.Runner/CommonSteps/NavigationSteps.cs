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
        [Given]
        public void Given_I_am_on_the_calculator_home_page()
        {
            WebBrowser.Current.GoToNoWait("http://www.calculator.net/");
        }

    }
}
