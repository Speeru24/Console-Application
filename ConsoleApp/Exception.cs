using System;
class ExceptionClass
{
    public static void OuterFunction()
    {
        InnerFunction();
    }

    public static void InnerFunction()
    {
        try
        {
            throw new Exception();
        }
        //catch(Exception ex)
        //{
        //    //throw new Exception();
        //}
        finally
        {
            Console.WriteLine("Finally Executed in InnerFunction");
        }
    }

    public static void Main()
    {
        Console.WriteLine("Exception Handling");
        try
        {
            OuterFunction();
            throw new ArithmeticException();
        }
        catch(ArithmeticException ex)
        {
            
            Console.WriteLine("Exception Handled in catch");
            Console.WriteLine("Message : " + ex.Message);
            Console.WriteLine("TargetSite : " + ex.TargetSite);
            Console.WriteLine("Source : " + ex.Source);
            Console.WriteLine("StackTrace : " + ex.StackTrace);
            Console.WriteLine("InnerException : " + ex.InnerException);
            Console.WriteLine("ArithmeticException Handled");
            throw new FormatException();

        }
        catch(FormatException ex)
        {
            Console.WriteLine("FormatException Handled" + ex.Message);
        }

        Console.ReadLine();
    }
}