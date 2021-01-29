using System;

class stringReverse
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name : ");
        string name = Console.ReadLine();
        int strlen = name.Length;

        Console.WriteLine("The name you entered is " + name + " has length: "+ strlen);
		Console.WriteLine("\n");
        char[] nameArray = name.ToCharArray();
        string revStr = "";

        while (strlen > 0)
        {
            revStr = revStr + name[strlen-1];
            strlen--;
        }
        Console.WriteLine("The reverse of string using while loop is " + revStr);


        revStr = "";
        strlen = name.Length;
        for(int i = strlen - 1; i >= 0; i--)
        {
            revStr = revStr + name[i];
        }
        Console.WriteLine("The reverse of string using for loop is " + revStr);

        Console.WriteLine("Last Index: " + Array.LastIndexOf(nameArray,'i'));




        Console.ReadLine();
    }
}