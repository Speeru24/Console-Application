using System;
public class Parent
{
    public void Write()
    {
        Console.WriteLine ("Parent Class write method");
    }
}
 
public class Child: Parent
{
    public new void Write()
    {
        Console.WriteLine ("Child Class write method");
    }
   
    public static void Main()
    {
        Child C1 = new Child();
        C1.Write();
        //Type caste C1 to be of type Parent and call Write () method
        ((Parent) C1).Write();

        Parent p1 = new Child();
        p1.Write();
        
    }
}