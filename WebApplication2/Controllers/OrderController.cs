using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult SearchOrder(Models.SalesOrdersService model)
        {
            ViewBag.list = model.Find();
            return View("SearchOrder");
        }
    }
}