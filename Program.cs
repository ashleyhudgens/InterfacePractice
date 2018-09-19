using System;


namespace TestingInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var testing = new Arithmetic();

            testing.getTypeOfArithmetic();
            testing.getFirstOperand();
            testing.getSecondOperand();
            testing.getDisplayTotal();

            //keep cmd prompt open
            Console.ReadLine();
        }
    }
}
