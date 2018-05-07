using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class SalesShippers
    {
        /// <summary>
        /// 出貨商編號
        /// </summary>
        public int ShipperId { get; set; }

        /// <summary>
        /// 出貨商名稱
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// 出貨商電話
        /// </summary>
        public string Phone { get; set; }
    }
}