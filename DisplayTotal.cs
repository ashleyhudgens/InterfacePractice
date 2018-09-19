using System;


namespace CalculatorApp
{
    class DisplayTotal
    {
        public void getDisplayTotal(String typeOfArithmetic, double firstOperand, double secondOperand, double total)
        {
            switch (typeOfArithmetic)
            {
                case "add":
                Console.Write("The total of " + firstOperand + "+" + secondOperand + " is " + total);
                    break;
                case "subtract":
                Console.Write("The total of " + firstOperand + "-" + secondOperand + " is " + total);
                    break;
                case "multiply":
                Console.Write("The total of " + firstOperand + "*" + secondOperand + " is " + total);
                    break;
                case "divide":
                Console.Write("The total of " + firstOperand + "/" + secondOperand + " is " + total);
                    break;
                default:
                Console.Write("Invalid");
                    break;
            }
        }
    }
}
