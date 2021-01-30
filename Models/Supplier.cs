using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _91APPTesting.Models
{
    [Serializable]
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }

    public class SupplierDao 
    {
        private static IList<Supplier> _supplier = new List<Supplier>()
        {
            new Supplier() { SupplierId = 1, Name = "Apple", Country = "America" },
            new Supplier() { SupplierId = 2, Name = "Google", Country = "America" },
            new Supplier() { SupplierId = 3, Name = "Asus", Country = "ROC" },
        };

        public IList<Supplier> GetSupplers() 
        {
            return _supplier;
        }
    }
}