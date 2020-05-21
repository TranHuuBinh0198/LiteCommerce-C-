using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DomainModels
{
    class Order
    {
        /// <summary>
        /// 
        /// </summary>
        public int OrderID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int CustomerID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int EmployeeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int OrderDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int RequiredDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ShippedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ShipperID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Freight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ShipAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ShipCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ShipCountry { get; set; }
    }
}
