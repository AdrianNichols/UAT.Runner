using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatiN.Core;

namespace UAT.Runner.Pages
{
    internal class CalculatorHomePage : Page
    {
        private const string NUM_ON_CLICK = "r({0})";
        private const string PLUS_ON_CLICK = "r('+')";
        private const string MINUS_ON_CLICK = "r('-')";
        private const string EQUALS_ON_CLICK = "r('=')";
        private const string CALC_ANSWER_ID = "sciOutPut";

        private Span CalcButton(string onClickToMatch)
        {
            return WebBrowser.Current.Span(Find.By("onclick", onClickToMatch));
        }

        internal Span NumberButton(int num)
        {
            return CalcButton(String.Format(NUM_ON_CLICK, num));
        }

        internal Span PlusButton
        {
            get
            {
                return CalcButton(PLUS_ON_CLICK);
            }
        }

        internal Span MinusButton
        {
            get
            {
                return CalcButton(MINUS_ON_CLICK);
            }
        }

        internal Span EqualsButton
        {
            get
            {
                return CalcButton(EQUALS_ON_CLICK);
            }
        }

        internal string CalcAnswer
        {
            get
            {
                return WebBrowser.Current.Div(Find.ById(CALC_ANSWER_ID)).Text;
            }
        }

    }
}
