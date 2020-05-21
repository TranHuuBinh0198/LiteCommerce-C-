using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DomainModels
{
    class Product
    {
        /// <summary>
        /// 
        /// </summary>
        public int ProductID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ProductName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SupplierID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int CategoryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int QuantityPerUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int UnitPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Descriptions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int PhotoPath { get; set; }
    }
}
