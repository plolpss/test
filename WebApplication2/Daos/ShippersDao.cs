using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Daos
{
    public class ShippersDao : BaseDao
    {
        public List<SalesShippers> GetAllShippers()
        {
            List<SalesShippers> result = new List<SalesShippers>();
            using (SqlConnection conn = GetSqlConnection())
            {
                string sql = "select  * from Sales.Shippers";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    result.Add(new SalesShippers
                    {
                        ShipperId = int.Parse(row["ShipperID"].ToString()),
                        CompanyName = row["CompanyName"].ToString(),
                        Phone = row["Phone"].ToString(),
                    });
                }
            }
            return result;
        }
    }
}