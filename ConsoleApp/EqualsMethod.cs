using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class EqualsMethod
{
    public class Customer
    {
        public string FirstName = "Shishir";
        public string lastName = "Shishir";
    }
	public static void Main()
    {
        Customer c1 = new Customer();
        Customer c2 = c1;
        
        Console.WriteLine(c1.FirstName == c2.lastName);
        Console.WriteLine(c1.FirstName.Equals(c2.lastName));

        Customer c3 = new Customer();
        Customer c4 = new Customer();
        Console.WriteLine(c3==c4);
        Console.WriteLine(c3.Equals(c4));


        Console.ReadLine();
    }
}
