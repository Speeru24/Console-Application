using System;
public class pattern
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Pattern");
        int i, j, k,l;

        /*
        1
        12
        123
        1234
        12345
        */
        Console.WriteLine("Pattern 1");
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");
        /*
            5
           44
          333
         2222
        11111
        */
        Console.WriteLine("Pattern 2");
        for (i = 5; i > 0; i--)
        {
            for (j = 1; j < i; j++)
            {
                Console.Write(" ");
            }
            for (k = 5; k >= i; k--)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n");

        /*
            5
           54
          543
         5432
        54321
        */
        Console.WriteLine("Pattern 3");
        for (i = 5; i > 0; i--)
        {
            for (j = 1; j < i; j++)
            {
                Console.Write(" ");
            }
            for (k = 5; k >= i; k--)
            {
                Console.Write(k);
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n");
        /*
            1
           12
          123
         1234
        12345
    */
        Console.WriteLine("Pattern 4");
        for (i = 1; i <= 5; i++)
        {
            for (j = 5; j > i; j--)
            {
                Console.Write(" ");
            }
            for (k = 1; k <= i; k++)
            {
                Console.Write(k);
            }
            Console.WriteLine();
        }


        Console.WriteLine("\n");
        /*
            1
           121
          12321
         1234321
        123454321
    */
        Console.WriteLine("Pattern 5");
        for (i = 1; i <= 5; i++)
        {
            for (j = 5; j > i; j--)
            {
                Console.Write(" ");
            }
            for (k = 1; k <= i; k++)
            {
                Console.Write(k);
            }
            for(l=i-1;l> 0; l--)
            {
                Console.Write(l);
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n");
        /*
        1
        23
        456
        78910
        */
        Console.WriteLine("Pattern 6");
        int sum = 1;
        for (i = 1; i < 5; i++)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write(sum + " ");
                sum++;
            }
            Console.WriteLine();
        }


        Console.ReadLine();
    }
}