using System;
interface I1
{
    //public int a = 1;//cannot contains fields
    void Add();
}

interface I2
{
    void Add();
}

abstract class A
{
    public int b = 1;
    public string AbstractProperty { get; set; }
    public abstract void Add();
}

class P: A, I1, I2
{
    public string AProperty { get; set; }

    void I1.Add()
    {
        Console.WriteLine("I1's Add");
    }

    void I2.Add()
    {
        Console.WriteLine("I2's Add");
    }

    public override void Add()
    {
        Console.WriteLine("Default implementation");
    }
}





class MainClass
{
    public static void Main(string [] args)
    {
        Console.WriteLine("***Start***");
        P p = new P();
        p.Add();

        ((I1)p).Add();

        ((I2)p).Add();


        A a = new P();
        a.AbstractProperty = "P's Abstract";

        Console.WriteLine("****End****");
    }
}











