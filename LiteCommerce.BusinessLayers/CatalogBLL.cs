using LiteCommerce.DataLayers;
using LiteCommerce.DomainModels;
using LiteCommerce.DataLayers.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.BusinessLayers
{
    /// <summary>
    /// 
    /// </summary>
    public static class CatalogBLL
    {
        /// <summary>
        /// 
        /// </summary>
        private static SupplierDAL SupplierDB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionstring"></param>
        public static void Initialize(string connectionstring)
        {
            SupplierDB = new DataLayers.SqlServer.SupplierDAL(connectionstring);
        }
        public static List<Supplier> Supplier_List(int page, int pageSize, string searchValue)
        {
            if (page < 1)
                page = 1;
            if (pageSize <= 0)
                pageSize = 30;
            return SupplierDB.List(page, pageSize, searchValue);
        }
    }
}
