using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class SalesCustomer
    {
        /// <summary>
        /// 客戶編號
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// 客戶公司名稱
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// 聯絡姓名
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// 客戶地址
        /// </summary>
        public string Address { get; set; }


    }
}