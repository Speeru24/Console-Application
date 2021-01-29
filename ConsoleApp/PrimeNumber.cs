using System;


public class PrimeNumber
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("***Prime Nummber***");
            Console.WriteLine("Enter max number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                bool flag = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    Console.Write(i + "\t");
                }
            }
            Console.ReadLine();
        }
        catch (Exception ex)
        {

        }

    }
}