using System;

namespace CalculatorApp
{
    class UserInput : ITestInterface
    {
        public String typeOfArithmetic { get; set; }
        public double firstOperand { get; set; }
        public double secondOperand { get; set; }
        public String getTypeOfArithmetic()
        {
            Console.Write("What type of arithmetic? Add, subtract, multiply, divide: ");
            typeOfArithmetic = Console.ReadLine();
            return typeOfArithmetic;
        }
        public double getFirstOperand()
        {
            String firstNumber;

            Console.Write("What is the first number: ");
            firstNumber = Console.ReadLine();
            firstOperand = Convert.ToDouble(firstNumber);
            return firstOperand;
        }
        public double getSecondOperand()
        {
            String secondNumber;

            Console.Write("What is the second number: ");
            secondNumber = Console.ReadLine();
            secondOperand = Convert.ToDouble(secondNumber);
            return secondOperand;
        }

        public double getTotal(String typeOfArithmetic)
        {
            double total;
            if (typeOfArithmetic == "add")
            {
                total = firstOperand + secondOperand;
                return total;
            } else if (typeOfArithmetic == "subtract")
            {
                total = firstOperand - secondOperand;
                return total;

            } else if (typeOfArithmetic == "multiply")
            {
                total = firstOperand * secondOperand;
                return total;

            } else if (typeOfArithmetic == "multiply")
            {
                total = firstOperand * secondOperand;
                return total;

            } else if (typeOfArithmetic == "divide")
            {
                total = firstOperand / secondOperand;
                return total;

            } else
            {
                String error = "Invalid";
                double errorCode = Convert.ToDouble(error);
                return errorCode;
            }

        }
    }
}
