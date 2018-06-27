using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using WebApplication2.Daos;

namespace WebApplication2.Models
{
    public class SalesOrdersService
    {
        /// <summary>
        /// 取得 Order by 訂單編號
        /// </summary>
        /// <param name="orderID">訂單編號</param>
        /// <returns></returns>
        public SalesOrders GetOrder(int orderID)
        {
            SalesOrdersDao dao = new SalesOrdersDao();
            return dao.GetOrderById(orderID);
        }

        /// <summary>
        /// 取得 Orders by 條件
        /// </summary>
        /// <returns></returns>
        public IList<SalesOrders> GetOrders(OrderQueryArg arg)
        {
            CustomerService customerService = new CustomerService();

            SalesOrdersDao orderDao = new SalesOrdersDao();
            // 取得所有訂單後進行篩選  (注意: 此處應將查詢條件串入SQL中為較好之寫法)
            IEnumerable<SalesOrders> currentOrders = orderDao.GetAllOrders();

            // 訂單編號
            if (arg.OrderID.HasValue)
            {
                currentOrders = currentOrders.Where(m => m.OrderID == arg.OrderID.Value);
            }

            // 客戶名稱 (like 查詢)
            if (!string.IsNullOrWhiteSpace(arg.CompanyName))
            {
                currentOrders =
                    currentOrders.Where(
                        m => customerService.GetCompanyName(m.CustomerID).Contains(arg.CompanyName)
                    );
            }

            // 員工編號
            if (arg.EmployeeID.HasValue)
            {
                currentOrders = currentOrders.Where(m => m.EmployeeID == arg.EmployeeID.Value);
            }

            // 出貨公司
            if (arg.ShipperID.HasValue)
            {
                currentOrders = currentOrders.Where(m => m.ShipperID == arg.ShipperID.Value);
            }

            return currentOrders.OrderBy(m => m.OrderID).ToList();
        }

        /// <summary>
        /// 新增 Order
        /// </summary>
        /// <param name="order">欲新增的訂單資料</param>
        public void InsOrder(SalesOrders order)
        {
            SalesOrdersDao orderDao = new SalesOrdersDao();
            orderDao.AddNewOrderReturnNewOrderId(order);
        }

        /// <summary>
        /// 更新 Order
        /// </summary>
        /// <param name="order">欲更新的訂單資料</param>
        public void UpdOrder(SalesOrders order)
        {
            SalesOrdersDao orderDao = new SalesOrdersDao();
            orderDao.UpdateOrder(order);
        }

        /// <summary>
        /// 刪除 Order
        /// </summary>
        /// <param name="orderID">訂單編號</param>
        public void DelOrder(int orderID)
        {
            SalesOrdersDao orderDao = new SalesOrdersDao();
            orderDao.DeleteOrder(orderID);
        }

    }

}