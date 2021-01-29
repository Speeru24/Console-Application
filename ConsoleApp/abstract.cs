using System;

abstract class Customer
{
    public abstract void Print();
    public void GetData()
    {
        Console.WriteLine("GetData Method");
    }
}


class Program: Customer
{
    public override void Print() 
    {
        Console.WriteLine("Abstract Print Method");
    }

    public static void Main()
    {
        Program P = new Program();
        P.Print();
        P.GetData();

        //The following lines gives - Cannot create an instance of the abstract class or interface 'Customer'
        //Customer C = new Customer();
        //C.Print();
        //C.GetData();

        Customer C = new Program();

        C.Print();
        C.GetData();

    }
}