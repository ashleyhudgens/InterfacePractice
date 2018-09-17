using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public interface ITestInterface
    {
        //only declarations in an interface, must use class to define variables
        int firstOperand { get; set; }
        int secondOperand { get; set; }

        int total { get; set; }
    }
}
