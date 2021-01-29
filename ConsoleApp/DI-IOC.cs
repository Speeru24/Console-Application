using System;

public interface ICustomerDataAccess
{
    string GetCustomerName(int id);
}

public class CustomerDataAccess : ICustomerDataAccess
{
    public CustomerDataAccess()
    {
    }

    public string GetCustomerName(int id)
    {
        return "Dummy Customer Name"; // get it from DB in real app
    }
}

public class CustomerBusinessLogic
{
    ICustomerDataAccess _custDataAccess;

    public CustomerBusinessLogic()
    {
        _custDataAccess = DataAccessFactory.GetObject();
    }

    public string GetCustomerName(int id)
    {
        return _custDataAccess.GetCustomerName(id);
    }
}

//public class DataAccess
//{
//    public DataAccess()
//    {
//    }

//    public string GetCustomerName(int id)
//    {
//        return "Dummy Customer Name"; // get it from DB in real app
//    }
//}

public class DataAccessFactory
{
    public DataAccessFactory()
    {

    }

    public static ICustomerDataAccess GetObject()
    {
        return new CustomerDataAccess();
    }
}

public class Program
{
    public static void Main()
    {
        CustomerBusinessLogic cbl = new CustomerBusinessLogic();
        Console.WriteLine(cbl.GetCustomerName(1));

        Console.ReadLine();
    }
}
