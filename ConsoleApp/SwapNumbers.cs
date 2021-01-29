using System;
public class SwapNumbers
{
    public static void Main(string[] args)
    {
	Console.WriteLine("Swap Numbers without using third variable");	
	int a = 3;
	int b = 5;
	Console.WriteLine("a=" +a + " b=" + b);
	a = a + b;//3+5=8
	b = a - b;//8-5=3
	a = a - b;//8-3=5
	Console.WriteLine("a=" +a + " b=" + b);	
        Console.ReadLine();
    }
}