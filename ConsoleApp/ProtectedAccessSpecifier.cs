using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protected_Specifier
{
    public class access
    {
        protected string name;
    }

    public class Derived:access
    {
        public void getName()
        {
            Console.Write("Enter your name:\t");
            name = Console.ReadLine();
        }
        public void PrintName()
        {
            Console.WriteLine("My name is " + name);
        }
    }

    public class Program
    {
        //public void PrintName()
        //{
        //    Console.WriteLine("My name is " + name);
        //}
        static void Main(string[] args)
        {
            Derived ac = new Derived();
            ac.getName();
            ac.PrintName();

            Console.ReadLine();
        }
    }
}