using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Base
{
    public class CustomerBusinessLogic
    {
        DataAccess _dataAccess;
        public CustomerBusinessLogic()
        {
            _dataAccess = new DataAccess();
        }

        public string GetCustomerName(int id)
        {
            return _dataAccess.GetCustomerName(id);
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
