using System;


namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            String typeOfArithmetic;
            String firstNumber;
            String secondNumber;
            var getOperands = new TestInterfaceClass();
            var display = new Results();
            int result;

            //Get user input per arithmetic type
            Console.Write("What type of arithmetic? Addition, Subtraction, Division or Multiplication: ");
            typeOfArithmetic = Console.ReadLine();

            //Get user input for first number and convert from String to int
            Console.Write("Enter the first number: ");
            firstNumber = Console.ReadLine();
            getOperands.firstOperand = Convert.ToInt32(firstNumber);

            //Get user input for second number and convert from String to int
            Console.Write("Enter the second number: ");
            secondNumber = Console.ReadLine();
            getOperands.secondOperand = Convert.ToInt32(secondNumber);

            //determine calculations based on arithmetic type
            if (typeOfArithmetic.ToLower() == "addition")
            {
                String operatorType = "+";
                result = getOperands.Add();
                display.displayTotal(getOperands.firstOperand, getOperands.secondOperand, result, operatorType);
            }
            else if (typeOfArithmetic.ToLower() == "subtraction")
            {
                String operatorType = "-";
                result = getOperands.Subtract();
                display.displayTotal(getOperands.firstOperand, getOperands.secondOperand, result, operatorType);
            }
            else if (typeOfArithmetic.ToLower() == "multiplication")
            {
                String operatorType = "*";
                result = getOperands.Multiply();
                display.displayTotal(getOperands.firstOperand, getOperands.secondOperand, result, operatorType);
            }
            else if (typeOfArithmetic.ToLower() == "division")
            {
                String operatorType = "/";
                result = getOperands.Divide();
                display.displayTotal(getOperands.firstOperand, getOperands.secondOperand, result, operatorType);
            } else
            {
                Console.Write("Invalid arithmetic type");
            }
                //causes cmd prompt to stay open for debugging
                Console.ReadLine();
        }
    }
}
