using _91APPTesting.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _91APPTesting.Controllers
{
    public class HomeController : Controller
    {
        private static BaseDao BaseDao = new BaseDao();
        [HttpGet]
        public ActionResult Index() 
        {
            var orderList = BaseDao.OrderDao.GetOrderList();
            return View(orderList);
        }

        public ActionResult ProductDetail(int id) 
        {
            var model = BaseDao.ProductDao.GetPrduct(id);
            return View("ProductDetail", model);
        }

        [HttpPost]
        public void DoEditOrderList() 
        {
            var reader = new StreamReader(HttpContext.Request.InputStream);
            var data = reader.ReadToEnd();
            var editList = JsonConvert.DeserializeObject<List<EditOrderList>>(data);
            var orders = BaseDao.OrderDao.GetOrderList();
            foreach (var order in orders) 
            {
               var isCheck = editList.Where(x => x.OrderId == order.OrderId).Select(x=> x.IsCheck).FirstOrDefault();
                if (isCheck) 
                {
                    order.Status = OrderStatus.Shipped;
                }
            } 
        }

        //[HttpPost]
        //public ActionResult Login()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Register()
        //{
        //    return View();
        //}
    }

    [Serializable]
    public class EditOrderList 
    {
        public string OrderId { get; set; }
        public bool IsCheck { get; set; }
    }
}