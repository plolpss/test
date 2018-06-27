using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Daos
{
    public class EmployeesDao : BaseDao
    {
        public List<HREmployees> GetAllEmployees()
        {
            List<HREmployees> result = new List<HREmployees>();
            using (SqlConnection conn = GetSqlConnection())
            {

                string sql = "select  * from HR.Employees";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                DataSet ds = new DataSet();
                adapter.Fill(ds);


                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    result.Add(new HREmployees
                    {
                        EmployeeId = int.Parse(row["EmployeeID"].ToString()),
                        LastName = row["LastName"].ToString(),
                        FirstName = row["FirstName"].ToString()
                    });
                }
            }
            return result;
        }
    }
}