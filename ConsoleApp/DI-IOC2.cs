using System;

namespace CustomerUI
{
    public class Program
    {
        public static void Main(string [] args)
        {
            Customer obj = new Customer(new SQLServerDal());
            obj.Name = "Ganesh";
            obj.Address = "Thakurli";
            obj.Add();
            Console.ReadLine();
        }
    }

    //Middle Layer
    public class Customer
    {
        public IDal odal;
        public string Name { get; set; }
        public string Address { get; set; }
        public Customer(IDal iobj)
        {
            odal = iobj;
        }

        public void Add()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Address);
            //DAL


            odal.Add();
        }
    }

    //Loose Coupling
    public interface IDal
    {
        void Add();
    }

    //DAL
    public class SQLServerDal: IDal
    {
        public void Add()
        {
            Console.WriteLine("Data Inserted in SQL");
        }
    }

    public class OracleServerDal : IDal
    {
        public void Add()
        {
            Console.WriteLine("Data Inserted in Oracle");
        }
    }
}

