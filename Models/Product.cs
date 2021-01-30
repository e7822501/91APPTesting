using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _91APPTesting.Models
{
    [Serializable]
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int OriginPrice { get; set; }
        public string Description { get; set; }
        public int SupplierId { get; set; }
    }

    public class ProductDao 
    {
        private static IList<Product> _products = new List<Product>()
        {
            new Product(){ ProductId =  1, Name = "IPhoneSE", Price = 100, OriginPrice = 90, Description = "THE CP VERY HIGH", SupplierId = 1 },
            new Product(){ ProductId =  2, Name = "IPhone6S", Price = 120, OriginPrice = 100, Description = "God Merchant", SupplierId = 1 },
            new Product(){ ProductId =  3, Name = "IPhone12", Price = 200, OriginPrice = 150, Description = "Two Eyes", SupplierId = 1 },
            new Product(){ ProductId =  4, Name = "IPhone12Pro", Price = 150, OriginPrice = 120, Description = "Three Eyes", SupplierId = 1 },
        };

        public Product GetPrduct(int ProductId) 
        {
            return _products.Where(x => x.ProductId == ProductId).FirstOrDefault();
        }
        public IList<Product> GetProducts() 
        {
            return _products;
        }
    }
}