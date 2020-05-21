using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DomainModels
{
    class ProductAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        public int AttributeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ProductID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int AttributeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int AttributeValues { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
