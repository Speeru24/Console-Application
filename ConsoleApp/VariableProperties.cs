using System;

namespace Program
{
    class A
    {
        //public string PublicName = "PubShishir variable";
        //private string PrivateName = "PriShishir variable";
        //protected string ProtectedName = "ProShishir variable";
        //internal string IntName = "IntShishir variable";
        //protected internal string ProIntName = "ProIntShishir variable";

        public string pub_LName { get; set; }
        private string pri_LName { get; set; }
        protected string pro_LName { get; set; }
        internal string int_LName { get; set; }
        protected internal string pro_int_LName { get; set; }

        public A()
        {
            Console.WriteLine("A's constructor called");
        }

        ~A()
        {
            Console.WriteLine("A's destructor called");
        }
    }

    class B: A
    {

        public string pub_Name { get; set; }
        private string pri_Name { get; set; }
        protected string pro_Name { get; set; }
        internal string int_Name { get; set; }
        protected internal string pro_int_Name { get; set; }
        public B()
        {
            Console.WriteLine("B's constructor called");
        }

        ~B()
        {
            Console.WriteLine("B's destructor called");
        }


    }

    class C : B
    {
        public C()
        {
            Console.WriteLine("C's constructor called");
        }

        ~C()
        {
            Console.WriteLine("C's destructor called");
        }

        public static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();
            //Default Rule for accessing variables, properties, and methods for different access modifiers

            //BASE CLASS
            //a.
            //Shown Access Modifiers: public, internal, protected internal
            //Hidden: private, protected

            //DERIVED CLASS
            //B.
            //Shown Access Modifiers: PROTECTED, public, internal, protected internal
            //Hidden: private

            //B bb = new A();//gives error
            //Console.WriteLine("*****Variable*****");
            //Console.WriteLine(a.PublicName);
            //Console.WriteLine(a.ProIntName);
            //Console.WriteLine(a.IntName);
            //Console.WriteLine("*****Property*****");
            //a.pub_LName = "pub_LName Property";
            //a.int_LName = "int_LName Property";
            //a.pro_int_LName = "pro_int_LName Property";
            //Console.WriteLine(a.pub_LName);
            //Console.WriteLine(a.int_LName);
            //Console.WriteLine(a.pro_int_LName);
            
            Console.ReadLine();
        }
    }

}

