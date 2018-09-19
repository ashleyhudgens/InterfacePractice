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
        //all are automatically public
        String typeOfArithmetic { get; set; }
        double firstOperand { get; set; }
        double secondOperand { get; set; }
        String getTypeOfArithmetic();
        double getFirstOperand();
        double getSecondOperand();
        double getTotal(String typeOfArithmetic);
    }
}
