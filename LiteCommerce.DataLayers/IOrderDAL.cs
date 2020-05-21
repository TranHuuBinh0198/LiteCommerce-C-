using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DataLayers
{
    class IOrderDAL
    {
        int Add(Order data);
        bool Update(Order data);
        bool Delete(int[] OrderIDs);
        Order Get(int OrderID);
        List<Order> List(int page, int pageSize, string searchValue);
    }
}
