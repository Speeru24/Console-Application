using System;
using System.Collections.Generic;
class Dictionary
{
    public static void Main(string [] args)
    {
        Console.WriteLine("Dictionary class");

        Customer cust1 = new Customer()
        {
            CustomerId = 1,
            Name = "Shishir",
            Salary = "100000"
        };

        Customer cust2 = new Customer()
        {
            CustomerId = 2,
            Name = "Shubham",
            Salary = "90000"
        };

        Customer cust3 = new Customer()
        {
            CustomerId = 3,
            Name = "Tushar",
            Salary = "99999"
        };


        Dictionary<int, Customer> custDictionary = new Dictionary<int, Customer>();
        custDictionary.Add(cust1.CustomerId, cust1);
        custDictionary.Add(cust2.CustomerId, cust2);
        custDictionary.Add(cust3.CustomerId, cust3);


        //Retrieve Single record
        Customer objcust = custDictionary[1];
        Console.WriteLine("Id = " + objcust.CustomerId + " Name=" + objcust.Name + " Salary=" + objcust.Salary);

        //retrieve all records
        foreach (KeyValuePair<int,Customer> custData in custDictionary)
        {
            objcust = custData.Value;
            Console.WriteLine("Id = " + objcust.CustomerId + " Name=" + objcust.Name + " Salary=" + objcust.Salary);
        }

        Console.ReadLine();


    }
}

class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Salary { get; set; }

}

