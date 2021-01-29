using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApplication.Properties
{
    public interface I1
    {
        void print();
    }

    interface I2
    {
        void print();
    }

    interface I3
    {
        void print();
    }

    public class Employee : I1, I2, I3
    {
        public void PrintFullName()
        {
            Console.WriteLine("Base Class");
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

        //Default Implemetation. Hence we need public access modifier.
        public void print()
        {
            Console.WriteLine("Default Implementation");
        }

    }


    public class ExplicitImplementationInterface
    {
        public static void Main(string[] args)
        {

            Employee e = new Employee();
            e.PrintFullName();
            ((I2)e).print();
            
            I1 Obj1 = new Employee();
            Obj1.print();

            e.print();

            Console.ReadLine();


        }
    }
}
