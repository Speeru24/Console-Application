using System;
using System.Linq;
using System.Collections.Generic;

public class List
{
	public static void Main(string[] args)
    {
        Console.WriteLine("List");
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



        //Convvert Array to List
        Customer[] arrCustomer = new Customer[3];
        arrCustomer[0] = cust1;
        arrCustomer[1] = cust2;
        arrCustomer[2] = cust3;

        List<Customer> customerList = arrCustomer.ToList();
        foreach (Customer cust in customerList)
        {
            Console.WriteLine(cust.CustomerId + " " + cust.Name + " " + cust.Salary);
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
