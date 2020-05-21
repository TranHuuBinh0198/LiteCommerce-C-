using System;
using System.Collections.Generic;

namespace LiteCommerce.DataLayers.SqlServer
{
    internal class SupplierDAL : ISupplierDAL
    {
        public SupplierDAL(string connectionString) : base(connectionString)
        {
        }

        internal List<Supplier> List(int page, int pageSize, string searchValue)
        {
            throw new NotImplementedException();
        }
    }
}