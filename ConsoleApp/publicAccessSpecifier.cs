using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Public_Access_Specifiers
{
    class access
    {
        // String Variable declared as public
        public string name;
        // Public method
        public void print()
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
            // Accepting value in public variable that is outside the class
            ac.name = Console.ReadLine();
            ac.print();
            Console.WriteLine("Arguement: " + args[0] +args[1]);
            Console.ReadLine();
        }
    }
}