using System;


namespace CalculatorApp
{

    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            var runProgram = new UserInput();
            var display = new DisplayTotal();

            //call methods to perform actions (getting user input on type of arithmetic, first/second operands
            String typeOfArithmetic = runProgram.getTypeOfArithmetic();
            double firstOperand = runProgram.getFirstOperand();
            double secondOperand = runProgram.getSecondOperand();

            //call methods to perform actions (calculating total depending on type of arithmetic, displaying total dependind on type of arithmetic
            double total = runProgram.getTotal(typeOfArithmetic);
            display.getDisplayTotal(typeOfArithmetic, firstOperand, secondOperand, total);

            //causes cmd prompt to stay open for debugging
            Console.ReadLine();
        }
    }
}
