using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Private_Access_Specifiers
{
    class access
    {
        // String Variable declared as private
        private string name;
        public void print() // public method
        {
            Console.WriteLine("\nMy name is " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            access ac = new access();
            Console.Write("Enter your name:\t");
            // raise error because of its protection level
            ac.name = Console.ReadLine();
            ac.print();
            Console.ReadLine();
        }
    }
}