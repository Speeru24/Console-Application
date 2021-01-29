using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//High Level module and low level module are dependent on Abstraction.
namespace IOC.DIP1
{
    public class CustomerBusinessLogic
    {
        IDataAccess _dataAccess;
        public CustomerBusinessLogic()
        {
            _dataAccess = DataAccessFactory.GetDataAccessObject();
        }

        public string GetCustomerName(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }
    }

    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessObject()
        {
            return new DataAccess();
        }

    }

    public interface IDataAccess
    {
        string GetCustomerName(int id);
    }

    public class DataAccess:IDataAccess
    {
        public DataAccess()
        {

        }
        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name.";
        }
    }
}
