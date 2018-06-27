using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Product
    {
        /// <summary>
        /// 產品編號
        /// </summary>
        public int ProductID { get; set; }
        /// <summary>
        /// 產品名稱
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 產品價格
        /// </summary>
        public decimal UnitPrice { get; set; }
    }
}