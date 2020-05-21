using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteCommerce.DomainModels;
using System.Data.SqlClient;

namespace LiteCommerce.DataLayers.SqlServer
{
    public class SupplierDAL : ISupplierDAL
    {
        private String connectionString;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        public SupplierDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int Add(Supplier data)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int[] supplierIDs)
        {
            throw new NotImplementedException();
        }

        public Supplier Get(int supplierID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public List<Supplier> List(int page, int pageSize, string searchValue)
        {
            List<Supplier> data = new List<Supplier>();
            if(!String )
            // Truy vấn dữ liệu từ CSDL...
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); //Mở kết nối
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = @"DECLARE @page int =2,
                            @pageSize int = 6,
		                    @searchValue nvarchar(255) = N'';

		                    SELECT * 
		                    from 
		                    ( SELECT *, 
       		                     ROW_NUMBER() OVER (ORDER BY SupplierID) AS RowNumber
  		                      FROM Suppliers
  		                      WHERE (@searchValue = N'') or (CompanyName like @searchValue)
		                    ) AS t
		                         WHERE t.RowNumber between (@page - 1)  @pageSize + 1 and @page  @pageSize
		                         ORDER BY t.RowNumber";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@page", page);
                    cmd.Parameters.AddWithValue("@pageSize", pageSize);
                    cmd.Parameters.AddWithValue("@searchValue", searchValue);

                    using (SqlDataReader dbReader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        while (dbReader.Read())
                        {
                            data.Add(new Supplier()
                            {
                                SupplierID = Convert.ToInt32(dbReader["SupplierID"]),
                                CompanyName = Convert.ToString(dbReader["CompanyName"]),
                                ContactName = Convert.ToString(dbReader["ContactName"]),
                                ContactTitle = Convert.ToString(dbReader["ContactTitle"]),
                                Address = Convert.ToString(dbReader["Address"]),
                                //Làm nốt các trường còn lại
                            });
                        }
                    }


                }
                connection.Close(); //Đóng kêt nối
            }
            return data;


        }

        public bool Update(Supplier data)
        {
            throw new NotImplementedException();
        }

        List<Supplier> ISupplierDAL.List(int page, int pageSize, string searchValue)
        {
            throw new NotImplementedException();
        }
    }
}
