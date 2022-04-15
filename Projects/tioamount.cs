using System;

namespace C_SharpFunctionsCourse
{
    class Program
    {
        
        static void Main(string[] args)
        {
            decimal Tip(decimal bill, decimal percent)
            {
                decimal tipAmount = bill * percent;
                return tipAmount;
            }

            decimal tip = Tip(33.00m, .15m);
            Console.WriteLine($"The tip is: {tip} ");
        }
    }
}