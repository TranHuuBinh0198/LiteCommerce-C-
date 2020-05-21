using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DataLayers
{
    interface ICustomerDAL
    {
        int Add(Customer data);
        bool Update(Customer data);
        bool Delete(int[] CustomerIDs);
        Customer Get(int CustomerID);
        List<Customer> List(int page, int pageSize, string searchValue);
    }
}
