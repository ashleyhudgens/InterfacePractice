using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Results
    {
        public void displayTotal(int x, int y, int z, String operatorType)
        {
            Console.WriteLine("The total of " + x + operatorType + y + " is " + z);
        }
    }
}
