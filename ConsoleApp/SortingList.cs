using System;
using System.Linq;
using System.Collections.Generic;

public class SortingList
{
    public static void Main(string[] args)
    {
        Console.WriteLine("*******************Integers******************");
        List<int> intList = new List<int>() { 2, 8, 6, 3, 9, 1, 5, 7, 4 };
        Console.WriteLine("Before Sort");
        foreach (int i in intList)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        Console.WriteLine("After Sort");
        intList.Sort();
        foreach (int i in intList)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Reverse Number");
        intList.Reverse();
        foreach (int i in intList)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        Console.WriteLine("*******************Strings******************");
        List<string> stringList = new List<string>() { "e","b","d","a","f","c" };
        Console.WriteLine("Before Sort");
        foreach (string s in stringList)
        {
            Console.Write(s + " ");
        }
        Console.WriteLine();

        Console.WriteLine("After Sort");
        stringList.Sort();
        foreach (string s in stringList)
        {
            Console.Write(s + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Reverse Number");
        stringList.Reverse();
        foreach (string s in stringList)
        {
            Console.Write(s + " ");
        }
        Console.WriteLine();



        Console.ReadLine();
    }
}