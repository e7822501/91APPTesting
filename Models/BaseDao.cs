using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _91APPTesting.Models
{
    public class BaseDao
    {
        public static OrderDao OrderDao = new OrderDao();
        public static CustomerDao CustomerDao = new CustomerDao();
        public static ProductDao ProductDao = new ProductDao();
        public static SupplierDao SupplierDao = new SupplierDao();
    }
}