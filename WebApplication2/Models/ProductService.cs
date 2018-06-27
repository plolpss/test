using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Daos;

namespace WebApplication2.Models
{
    public class ProductService
    {
        
        public IList<Product> GetAllProduct()
        {
            ProductsDao dao = new ProductsDao();
            return dao.GetAllProduct();
        }

        public decimal GetPrice(int productID)
        {
            ProductsDao dao = new ProductsDao();
            return dao.GetPrice(productID);
        }
    }
}