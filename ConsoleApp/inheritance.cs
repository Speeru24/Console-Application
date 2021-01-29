//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class A{
        public A(){
            Console.WriteLine("In public A");
        }
        static A(){
         Console.WriteLine("In Static A");   
        }
        public void Method(){ Console.WriteLine("In A method");}
    }

    public class B:A{
        public B(){
            Console.WriteLine("In public B");
        }
        static B(){
         Console.WriteLine("In Static B");   
        }
        public void Method(){ Console.WriteLine("In B method");}
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("A c= new B();");
            A c = new B();


            //Your code goes here
            Console.WriteLine("A a = new A();");
            A a = new A();
            //Console.WriteLine("B b = new A(); gives error");
            //B b = new A();//Gives Error
            //Console.WriteLine("A c= new B();");
            //A c1= new B();
            Console.WriteLine("B d = new B();");
            B d = new B();
            a.Method();
            //b.Method();//Gives Error
            c.Method();
            d.Method();
        }
    }
}