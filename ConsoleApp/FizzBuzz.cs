using System;
class FizzBuzz
{
    public static void Main()
    {
        Console.WriteLine("Enter number between 1 to 100,  no div by 3 then print Fizz. No div by 5 then Buzz");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
        Console.ReadLine();
    }
}
