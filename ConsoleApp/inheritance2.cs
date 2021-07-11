using System;

namespace Inheritance {
    public class GrandFather {
        public GrandFather () {
            Console.WriteLine ("GrandFather - Public constructor");
        }

        // private GrandFather () {
        //     Console.WriteLine ("GrandFather - Private constructor");
        // }

        static GrandFather () {
            Console.WriteLine ("GrandFather - Static constructor");
        }

        public virtual void GetDetails(){
            Console.WriteLine("GrandFather Details");
        }

        public void PrintGrandFatherDetails(){
            Console.WriteLine("Print GrandFather Details");
        }
    }

    public class Father : GrandFather {
        public Father () {
            Console.WriteLine ("Father - Public constructor");
        }

        static Father () {
            Console.WriteLine ("Father - Static constructor");
        }

        public new void GetDetails(){
            Console.WriteLine("Father Details");
        }

        public new void PrintFatherDetails(){
            Console.WriteLine("Print Father Details");
        }
    }

    // public class Child : Father {
    //     public Child () {
    //         Console.WriteLine ("Child - Public constructor");
    //     }

    //     static Child () {
    //         Console.WriteLine ("Child - Static constructor");
    //     }

    //     public new void GetDetails(){
    //         Console.WriteLine("Child Details");
    //     }
    // }


    public class Program {
        public static void Main(string [] args) {
            Console.WriteLine ("Main Method");

            Console.WriteLine("Father father = new Father()");
            Father father = new Father();
            father.GetDetails();
            father.PrintFatherDetails();
            father.PrintGrandFatherDetails();

            Console.WriteLine();

            Console.WriteLine("GrandFather grandFather = new Father()");
            GrandFather grandFather = new Father();
            grandFather.GetDetails();
            grandFather.PrintGrandFatherDetails();
            grandFather.PrintFatherDetails();

            Console.WriteLine();

            Console.WriteLine("GrandFather grandFather2 = new GrandFather()");
            GrandFather grandFather2 = new GrandFather();
            grandFather2.GetDetails();

            // Console.WriteLine("-----------------------");

            // Console.WriteLine("Child child = new Child()");
            // Child child = new Child();
            // child.GetDetails();

            // Console.WriteLine();

            // Console.WriteLine("Father father2 = new Child()");
            // Father father2 = new Child();
            // father2.GetDetails();

            // Console.WriteLine();

            // Console.WriteLine("GrandFather grandFather3 = new Child()");
            // GrandFather grandFather3 = new Child();
            // grandFather3.GetDetails();

            

            Console.WriteLine();

        }
    }
}