using System;
//Here there are 2 parties, 1. Program  2. MyClass
//now Program class wants to know which number is running in the for loop inside of MyClass LongRunning() 


// Next Step we create a delegate inside MyClass 

//** Then MyClass will says that anybody can pass me a function name as a parameter and I will ensure that I will pass the current running number.

//Now they are passing a callback method to MyClass as a parameter. And this callback method becomes a delegate in MyClass and informs Program this is the current running number.

class MyClass
{
    public delegate void CallBack(int i);
    public void LongRunning(CallBack obj)
    {
        for(int i = 0; i <= 10000; i++)
        {
            obj(i);
        }
    }
}

class Program
{
    public static void Main()
    {
        MyClass objClass = new MyClass();
        objClass.LongRunning(Callback);

        Console.ReadLine();
    }

    public static void Callback(int i)
    {
        Console.WriteLine(i);
    }
}
