using System;

public partial class PartialClass
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void PrintData2()
    {
        Console.WriteLine("Your Name2 is : " + FirstName + " " + LastName);
    }
}


public partial class PartialClass
{
    public void PrintData()
    {
        Console.WriteLine("Your Name is : " + FirstName + " " + LastName);
    }
}



public class Sample
{
	public static void Main(string[] args){
        PartialClass objPC = new PartialClass();
        objPC.FirstName = "Shishir";
        objPC.LastName = "Peeru";
        objPC.PrintData();
        objPC.PrintData2();
        Console.WriteLine("Hello World!!");
	}
}