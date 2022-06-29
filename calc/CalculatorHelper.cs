using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    internal class CalculatorHelper
    {
        public Form1 CalculatorParent { get; }

        public CalculatorHelper(Form1 calculatorParent) => CalculatorParent = calculatorParent;

        public void NumberButtonPressed(Control buttonPressed)
        {
            switch (CalculatorParent.foucsOnNum)
            {
                case 1:

                    CalculatorParent.num1 += int.Parse(buttonPressed.Tag.ToString() ?? string.Empty) * Math.Pow(10, CalculatorParent.num1Count);
                    CalculatorParent.num1Count++;
                    break;

                case 2:
                    CalculatorParent.num2 += int.Parse(buttonPressed.Tag.ToString() ?? string.Empty) * Math.Pow(10, CalculatorParent.num2Count);
                    CalculatorParent.num2Count++;
                    break;
            }

            CalculatorParent.MainLabel.Text += buttonPressed.Text;
        }
    }
}
