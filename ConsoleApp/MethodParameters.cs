using System;

class MethodParameters
{
    public static void Main(string[] args)
    {
        //Display(25, "Sadanand", "Peeru");//Will Work properly
        //Display("Sadanand", "Peeru",60);//Will give error
        Display(FName: "Shishir", LName: "Peeru", Age: 25);
        Console.ReadLine();
    }

    public static void Display(int Age, string FName, string LName)
    {
        Console.WriteLine("Age:" + 25 + " FName:" + FName + " LName:" + LName);
    }

}
