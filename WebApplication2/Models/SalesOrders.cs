using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class SalesOrders
    {

        /// <summary>
        /// 訂單詳細資料
        /// </summary>
        public List<OrderDetail> Details { get; set; }


        /// <summary>
        /// 訂單編號
        /// </summary>
        [DisplayName("訂單編號")]
        public int OrderID { get; set; }

        /// <summary>
        /// 客戶編號
        /// </summary>
        [DisplayName("客戶編號")]
        [Required]
        public int CustomerID { get; set; }

        /// <summary>
        /// 員工編號
        /// </summary>
        [DisplayName("員工編號")]
        [Required]
        public int EmployeeID { get; set; }

        /// <summary>
        /// 訂單日期
        /// </summary>
        [DisplayName("訂單日期")]
        [Required]
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// 需求日期
        /// </summary>
        [DisplayName("需求日期")]
        [Required]
        public DateTime RequiredDate { get; set; }

        /// <summary>
        /// 出貨日期
        /// </summary>
        [DisplayName("出貨日期")]
        public DateTime? ShippedDate { get; set; }

        /// <summary>
        /// 出貨商編號
        /// </summary>
        [DisplayName("出貨商編號")]
        [Required]
        public int? ShipperID { get; set; }

        /// <summary>
        /// 運費
        /// </summary>
        [DisplayName("運費")]
        [Required]
        public Decimal? Freight { get; set; }

        /// <summary>
        /// 出貨地址
        /// </summary>
        [DisplayName("出貨地址")]
        [Required]
        public string ShipAddress { get; set; }

        /// <summary>
        /// 出貨城市
        /// </summary>
        [DisplayName("出貨城市")]
        [Required]
        public string ShipCity { get; set; }

        /// <summary>
        /// 出貨地區
        /// </summary>
        [DisplayName("出貨地區")]
        public string ShipRegion { get; set; }

        /// <summary>
        /// 郵遞區號
        /// </summary>
        [DisplayName("郵遞區號")]
        public string ShipPostalCode { get; set; }

        /// <summary>
        /// 出貨國家
        /// </summary>
        [DisplayName("出貨國家")]
        [Required]
        public string ShipCountry { get; set; }
    }
}