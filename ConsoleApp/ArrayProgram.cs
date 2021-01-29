using System;
namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int[] n = new int[10]; /* n is an array of 10 integers */
            int i, j;

            /* initialize elements of array n */
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /* output each array element's value */
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }


            Console.WriteLine("\n\nPrinting a 2 dimensional array");
            int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (i = 0; i < arr1.GetLength(0); i++)
            {
                for (j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.WriteLine("[" + i + "][" + j + "] = " + arr1[i, j]);
                }
            }
            int[] A = { 4, 9, 3, 1, 7 };
            Console.WriteLine("\n\nArray Before Sorting");
            foreach(var a in A)
            {
                Console.WriteLine(a);
            }
            Array.Sort(A);
            Console.WriteLine("\n\nArray After Sorting");
            foreach (var a in A)
            {
                Console.WriteLine(a);
            }
            Array.Reverse(A);
            Console.WriteLine("\n\nArray After Reverse");
            foreach (var a in A)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}