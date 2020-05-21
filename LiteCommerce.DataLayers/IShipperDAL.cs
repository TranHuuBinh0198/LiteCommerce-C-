using LiteCommerce.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DataLayers
{
    interface IShipperDAL
    {
        int Add(Shipper data);
        bool Update(Shipper data);
        bool Delete(int[] ShipperIDs);
        Shipper Get(int ShipperID);
        List<Shipper> List(int page, int pageSize, string searchValue);
    }
}
