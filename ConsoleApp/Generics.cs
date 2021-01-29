using System;

class Calculator
{
    public static bool AreEqual<T>(T a, T b)
    {
        return a.Equals(b);//we cant use == to compare variables of Generics type.
    }
}


public class Generics
{
    public static void Main(string[] args)
    {
        bool c = Calculator.AreEqual<int>(5, 5);
        if (c)
        {
            Console.WriteLine("Both are equal");
        }
        else
        {
            Console.WriteLine("Both are not equal");
        }
        Console.ReadLine();
    }
}