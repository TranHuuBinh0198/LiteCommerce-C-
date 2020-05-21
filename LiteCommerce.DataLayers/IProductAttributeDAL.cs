using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DataLayers
{
    interface IProductAttributeDAL
    {
        int Add(ProductAttribute data);
        bool Update(ProductAttribute data);
        bool Delete(int[] ProductAttributeIDs);
        ProductAttribute Get(int ProductAttributeID);
        List<ProductAttribute> List(int page, int pageSize, string searchValue);
    }
}
