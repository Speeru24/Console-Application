using System;
namespace test
{

    internal class A
    {
        internal int a;
        internal int b;
        public void setData(int x, int y)
        {
            a = x;
            b = y;
        }
        public void getData()
        {
            Console.WriteLine("A:" + a + " B:" + b + " Sum:" + (a + b));
        }
    }
    class B:A
    {
        public static void Main()
        {
            A objA = new A();
            //objA.a = 5;
            //objA.b = 10;
            objA.setData(5, 15);
            objA.getData();
            //int sum = objA.Add(objA.a, objA.b);
            //Console.WriteLine("A:" + objA.a + " B:" + objA.b + " Sum:" + sum);
            Console.ReadLine();
        }
    }
}
