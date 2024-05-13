using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1= new Fraction();
        f1.SetTop(25);
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f1.GetFractionString());
        Fraction f2= new Fraction(5);
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f2.GetFractionString());
        Fraction f3= new Fraction(15, 8);
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine(f3.GetFractionString());


    }
}