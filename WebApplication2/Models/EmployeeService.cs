using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Daos;

namespace WebApplication2.Models
{
    public class EmployeeService
    {
        /// <summary>
        /// 取得所有員工
        /// </summary>
        /// <returns></returns>
        public IList<HREmployees> GetEmployees()
        {
            EmployeesDao dao = new EmployeesDao();
            return dao.GetAllEmployees();
        }
    }
}