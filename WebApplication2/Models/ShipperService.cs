using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Daos;

namespace WebApplication2.Models
{
    public class ShipperService
    {
        /// <summary>
        /// 取得所有貨運商
        /// </summary>
        /// <returns></returns>
        public IList<SalesShippers> GetShippers()
        {
            ShippersDao dao = new ShippersDao();
            return dao.GetAllShippers();
        }
    }
}