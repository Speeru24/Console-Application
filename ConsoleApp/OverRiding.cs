using System;
// Base class
public class BaseClass
{
    public virtual void Method1()
    {
        Console.Write("Base Class Method\n");
    }
}
// Derived class
public class DerivedClass : BaseClass
{
    public override void Method1()
    {
        Console.Write("Derived Class Method\n");
    }
}
// Using base and derived class
public class Sample
{
    public static void Main()
    {
        BaseClass b1 = new BaseClass();
        b1.Method1();
        // calling the overriden method
        DerivedClass objDC = new DerivedClass();
        objDC.Method1();
        // calling the base class method
        BaseClass objBC = (BaseClass)objDC;
        objBC.Method1();
        BaseClass b2 = new DerivedClass();
        b2.Method1();


    }
}