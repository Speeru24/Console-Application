using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace StringApplication
{
   class Program
   {
        static void Main(string[] args)
        {
            string[] words = { "Abcde", "left", "right", "Depend", "Elephant" };

            string[] copy = words;

            //ArrayList 

            PrintArray(words);
            PrintArray(copy);
            words[1] = "Hello";

            Program.PrintArray(words);
            Program.PrintArray(copy);

            Console.WriteLine("***********************************************\n");

            Console.WriteLine("Linq method syntax to check listy contains a particular string format.");
            IList<String> stringList = new List<String>()
            {
                "Shishir",
                "Lokesh",
                "Vaibhav",
                "Chandan",
                "Harsh"
            };

            var result = stringList.Where(s => s.Contains("i"));
            foreach(var name in result)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    
        public static void PrintArray(string[] strArray)
        {
            foreach (var word in strArray)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();
        }
    }
}
