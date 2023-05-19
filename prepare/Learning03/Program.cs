using System;
namespace Learning03
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction firstFraction = new Fraction();
            Console.WriteLine(firstFraction.GetFractionString());
            Console.WriteLine(firstFraction.GetDecimalValue());

            Fraction secondFraction = new Fraction(5,1);
            Console.WriteLine(secondFraction.GetFractionString());
            Console.WriteLine(secondFraction.GetDecimalValue());

            Fraction thirdFraction = new Fraction(3,4);
            Console.WriteLine(thirdFraction.GetFractionString());
            Console.WriteLine(thirdFraction.GetDecimalValue());

            Fraction forthFraction = new Fraction(1,3);
            Console.WriteLine(forthFraction.GetFractionString());
            Console.WriteLine(forthFraction.GetDecimalValue());
        }
    }
}