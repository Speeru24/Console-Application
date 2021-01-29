using System;

class OptionalParameters
{
    public static void Main(string [] args)
    {
        Console.WriteLine("optional Parameters using Params array");
        AddNumbers(5,3);//This will Work
        AddNumbers(5, 3,2);//This will Work
        AddNumbers(5, 3, 2,10);//This will Work
        AddNumbers(5, 3, new int[] { 10, 20, 30 });//This will Work

        Console.WriteLine("\n\noptional Parameters using Method Overloading");
        Add(5, 10);
        Add(5, 10, new int[] { 15 });

        Console.WriteLine("\n\noptional Parameters using parameter defaults");
        Display("Shishir", "Peeru");
        Display("Shishir", "Peeru", "Sadanand");

        Console.ReadLine();
    }

    //For params 
    public static void AddNumbers(int no1, int no2, params int[] additionalNumbers)
    {
        int result = no1 + no2;
        if(additionalNumbers != null)
        {
            foreach(int i in additionalNumbers)
            {
                result += i;
            }
        }
        Console.WriteLine("\nSum: " + result);
    }

    //For Method Overloading
    public static void Add(int no1, int no2)
    {
        Add(no1, no2, null);
    }

    public static void Add(int no1, int no2,int[] additionalNumbers)
    {
        int result = no1 + no2;
        if (additionalNumbers != null)
        {
            foreach (int i in additionalNumbers)
            {
                result += i;
            }
        }

        Console.WriteLine("\nSum: " + result);
    }

    //For Specifying Default parameters
    public static void Display(string FirstName, string LastName, string MiddleName = null)
    {
        string FullName = FirstName + " " + MiddleName + " " + LastName;
        Console.WriteLine("Full Name : " + FullName);
    }

    public static void Display(string FirstName, string LastName)
    {
        string FullName = FirstName + " : " + LastName;
        Console.WriteLine("Full Name : " + FullName);
    }


}