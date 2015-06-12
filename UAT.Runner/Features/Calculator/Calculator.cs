using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UAT.Runner.Pages;
using WatiN.Core;

namespace UAT.Runner.Features.Calculator
{
    [Binding]
    public class Calculator
    {
        private CalculatorHomePage _page = new CalculatorHomePage();
        [Given(@"I have entered the formula (.*) \+ (.*)")]
        public void GivenIHaveEnteredTheForumla(int p0, int p1)
        {
            _page.NumberButton(p0).ClickNoWait();
            _page.PlusButton.ClickNoWait();
            _page.NumberButton(p1).ClickNoWait();
        }

        [When(@"I press equals")]
        public void WhenIPressEquals()
        {
            _page.EqualsButton.ClickNoWait();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.IsTrue(_page.CalcAnswer == p0.ToString() + ".");
        }

    }
}
