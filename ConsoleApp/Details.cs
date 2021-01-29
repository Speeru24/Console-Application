using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApplication.Properties
{
    interface I1
    {
       void print();
    }

    interface I2
    {
        void print();
    }

    public class Employee
    {
        public void PrintFullName()
        {
            Console.WriteLine("Base Class");
        }   
    }

    public class FullTime : Employee, I1,I2
    {
        public new void PrintFullName()
        {
            base.PrintFullName();
            Console.WriteLine("Derived Class");
        }

        //Explicit Implementation of interface 
        //Note: Access modifiers must be removed for Explicit implementation of Interface.  
        void I1.print()
        {
            Console.WriteLine("Interface I1 Print method");
        }
        void I2.print()
        {
            Console.WriteLine("Interface I2 Print method");
        }

    }

    public class Details
    {
        public static void Main(string[] args)
        {
            FullTime f = new FullTime();
            f.PrintFullName();
            ((I2)f).print();

            I1 Obj1 = new FullTime();
            Obj1.print();
            Console.ReadLine();
        }
    }
}
