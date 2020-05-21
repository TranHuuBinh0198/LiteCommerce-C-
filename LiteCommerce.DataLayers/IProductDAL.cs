using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DataLayers
{
    interface IProductDAL
    {
        int Add(Product data);
        bool Update(Product data);
        bool Delete(int[] ProductIDs);
        Product Get(int ProductID);
        List<Product> List(int page, int pageSize, string searchValue);
    }
}
