using System;
class MultipleReturnType
{
    public static void Main()
    {
        int a = 5;
        int s = 0, c = 0;
        s, c = fun(a);
        Console.WriteLine(s + ' ' + c);


        Console.ReadLine();
    }

    static int fun(int x)
    {
        int ss, cc;
        ss = x * x;
        cc = x * x * x;
        return ss, cc;
    }

}