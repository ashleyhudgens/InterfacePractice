using System;


namespace TestingInterfaces
{
    public class Arithmetic : ISetUpInterface
    {
        public String typeOfArithmetic { get; set; }
        public double firstOperand { get; set; }
        public double secondOperand { get; set; }
        public double total { get; set; }
        public String displayTotal { get; set; }

        public String getTypeOfArithmetic()
        {
            Console.Write("Type of arithmetic (add, subtract, multiply, divide): ");
            typeOfArithmetic = Console.ReadLine();
            return typeOfArithmetic;
        }

        public double getFirstOperand()
        {
            Console.Write("First number: ");
            String firstnumber = Console.ReadLine();
            firstOperand = Convert.ToDouble(firstnumber);
            return firstOperand;
        }

        public double getSecondOperand()
        {
            Console.Write("Second number: ");
            String secondNumber = Console.ReadLine();
            secondOperand = Convert.ToDouble(secondNumber);
            return secondOperand;
        }

        public void getDisplayTotal()
        { 
            if (typeOfArithmetic == "add")
            {
                total = firstOperand + secondOperand;
                Console.Write("The total of " + firstOperand + "+" + secondOperand + " is " + total);
                
            }
            else if (typeOfArithmetic == "subtract")
            {
                total = firstOperand - secondOperand;
                Console.Write("The total of " + firstOperand + "-" + secondOperand + " is " + total);
                
            }
            else if (typeOfArithmetic == "multiply")
            {
                total = firstOperand * secondOperand;
                Console.Write("The total of " + firstOperand + "*" + secondOperand + " is " + total);
                
            }
            else if (typeOfArithmetic == "divide")
            {
                total = firstOperand / secondOperand;
                Console.Write("The total of " + firstOperand + "/" + secondOperand + " is " + total);
                
            }
            else
            {
                Console.Write("invalid");
            }

        }

    }
}
