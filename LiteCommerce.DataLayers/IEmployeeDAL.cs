using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DataLayers
{
    interface IEmployeeDAL
    {
        int Add(Employee data);
        bool Update(Employee data);
        bool Delete(int[] EmployeeIDs);
        Employee Get(int EmployeeID);
        List<Employee> List(int page, int pageSize, string searchValue);
    }
}
