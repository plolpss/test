using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class SalesOrdersService
    {
        private string GetConnStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }
        public List<SalesOrders> Find()
        {
            //建立資料庫連線
            string connStr = this.GetConnStr();
            SqlConnection conn = new SqlConnection(connStr);
            //撰寫SQL語法
            string sql = @"SELECT * FROM [Sales].[Orders]";
            //connection及sql語法傳入sqldataAdapter
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql,conn);
            //宣告DataSet物件
            DataSet ds = new DataSet();
            //將資料放入
            dataAdapter.Fill(ds);

            DataTable FindData = ds.Tables[0];

            List<SalesOrders> list = new List<SalesOrders>();
            foreach(DataRow item in FindData.Rows)
            {
                string shipdate;
                if (item["ShippedDate"] != null)
                {
                    shipdate = item["ShippedDate"].ToString();
                }
                else
                {
                    shipdate = " ";
                }
                //建立salesorders的模型
                SalesOrders model = new SalesOrders
                {
                    OrderID = int.Parse(item["OrderID"].ToString()),
                    CustomerID = int.Parse(item["CustomerID"].ToString()),
                    EmployeeID = int.Parse(item["EmployeeID"].ToString()),
                    OrderDate = DateTime.Parse(item["OrderDate"].ToString()),
                    RequiredDate = DateTime.Parse(item["RequiredDate"].ToString()),
                    ShippedDate = DateTime.Parse(shipdate),
                    ShipperID = int.Parse(item["ShipperID"].ToString()),
                    Freight = Decimal.Parse(item["Freight"].ToString()),
                    ShipAddress = (string)item["ShipAddress"],
                    ShipCity = (string)item["ShipCity"],
                    ShipRegion = (string)item["ShipRegion"],
                    ShipPostalCode = (string)item["ShipPostalCode"],
                    ShipCountry = (string)item["ShipCountry"],

                };
                list.Add(model);
            }
           
            return list;

        }
        
    }
}