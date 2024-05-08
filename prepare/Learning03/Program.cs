using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fract1 = new Fraction();
        Console.WriteLine(fract1.GetTop());
        Console.WriteLine(fract1.GetBotton());
        Console.WriteLine(fract1.GetFractionString());
        Console.WriteLine(fract1.GetDecimalValue());

        Fraction fract2 = new Fraction(5);
        Console.WriteLine(fract2.GetTop());
        Console.WriteLine(fract2.GetBotton());
        Console.WriteLine(fract2.GetFractionString());
        Console.WriteLine(fract2.GetDecimalValue());

        Fraction fract3 = new Fraction(3,4);
        Console.WriteLine(fract3.GetTop());
        Console.WriteLine(fract3.GetBotton());
        Console.WriteLine(fract3.GetFractionString());
        Console.WriteLine(fract3.GetDecimalValue());

        Fraction fract4 = new Fraction(1,3);
        Console.WriteLine(fract4.GetTop());
        Console.WriteLine(fract4.GetBotton());
        Console.WriteLine(fract4.GetFractionString());
        Console.WriteLine(fract4.GetDecimalValue());
    }
}