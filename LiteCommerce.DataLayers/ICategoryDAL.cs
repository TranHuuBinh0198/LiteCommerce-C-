using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DataLayers
{
    interface ICategoryDAL
    {
        int Add(Category data);
        bool Update(Category data);
        bool Delete(int[] CategoryIDs);
        Category Get(int CategoryID);
        List<Category> List(int page, int pageSize, string searchValue);
    }
}
