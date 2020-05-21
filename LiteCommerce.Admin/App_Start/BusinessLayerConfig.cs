using LiteCommerce.BusinessLayers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace LiteCommerce.Admin.App_Start
{
    /// <summary>
    /// khởi tạo các chức năng tác nghiệp cho ứng dụng
    /// </summary>
    public class BusinessLayerConfig
    {
        public static void Initialize()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LiteCommerce"].ConnectionString;
            CatalogBLL.Initialize(connectionString);
            //TODO: Bổ sung khởi tạo các BLL khác khi cần sử dụng
        }
    }
}