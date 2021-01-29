using System;

/// <summary>
/// Summary description for StaticClass
/// </summary>
public static class StaticClass
{
    //Static class cant have Instance Constructor   
    //public StaticClass()
    //{
    //    Console.WriteLine("Default Constructor");
    //}


    static StaticClass()
    {
        Console.WriteLine("Static Constructor");
    }

    public static void Print()
    {
        Console.WriteLine("Data Printed");
    }
}

public class Program
{
    public static void Main()
    {
        StaticClass.Print();
        Console.ReadLine();
    }
}