using System;
using System.Text.RegularExpressions;
class StringConcatenation
{
	public static void Main()
	{
		string name = "Shishir";
		string required = "Hello, I am {0}";
		
        // Create a string with string interpolation syntax.
        string animals = String.Format(required,name);
        // Call Console.WriteLine.
        Console.WriteLine(animals);
	
		Console.ReadLine();
	}
}