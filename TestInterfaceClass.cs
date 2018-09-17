using System;


namespace CalculatorApp
{
    public class TestInterfaceClass : ITestInterface
    {
       public int firstOperand { get; set; }
       
        public int secondOperand { get; set; }

        public int total { get; set; }

        public TestInterfaceClass()
        {
            //constructor
        }

        public int Add()
        {
            return firstOperand + secondOperand;
        }

        public int Subtract()
        {
            return firstOperand - secondOperand;
        }
        public int Multiply()
        {
            return firstOperand * secondOperand;
        }
        public int Divide()
        {
            return firstOperand / secondOperand;
        }
    }
}
