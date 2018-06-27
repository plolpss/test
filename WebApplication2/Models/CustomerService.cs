using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Daos;

namespace WebApplication2.Models
{
    public class CustomerService
    {
        /// <summary>
        /// 取得 CompnanyName by customerID
        /// </summary>
        /// <param name="customerID">客戶編號</param>
        /// <returns></returns>
        public string GetCompanyName(int customerID)
        {
            CustomersDao dao = new CustomersDao();

            List<SalesCustomer> customers = dao.GetAllCustomers(); ;
            SalesCustomer customer = customers.SingleOrDefault(m => m.CustomerId == customerID);

            return (customer != null) ? customer.CompanyName : null;
        }

        /// <summary>
        /// 取得所有客戶資料
        /// </summary>
        /// <returns></returns>
        public IList<SalesCustomer> GetCustomers()
        {
            CustomersDao dao = new CustomersDao();

            return dao.GetAllCustomers(); ;
        }
    }
}