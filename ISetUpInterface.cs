using System;


namespace TestingInterfaces
{
    interface ISetUpInterface
    {
        String typeOfArithmetic { get; set; }
        double firstOperand { get; set; }
        double secondOperand { get; set; }
        double total { get; set; }
        String displayTotal { get; set; }
    }
}
