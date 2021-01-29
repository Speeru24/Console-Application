using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    public class CustomerBusinessLogic
    {
        DataAccess _dataAccess;
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
        public static DataAccess GetDataAccessObject()
        {
            return new DataAccess();
        }

    }

    public class DataAccess
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
