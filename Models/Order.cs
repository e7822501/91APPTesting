using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _91APPTesting.Models
{
    public enum OrderStatus
    {
        UnPayed,
        PaymentComplete,
        Shipped
    }

    [Serializable]
    public class Order
    {
        public string OrderId { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
        public int Cost { get; set; }
        public OrderStatus Status { get; set; }
        public int CustomerId { get; set; }
    }

    public class OrderDao
    {
        private static IList<Order> _orders = new List<Order>()
        {
            new Order(){ OrderId = "A20202026001", ProductId = 1, Price = 100, Cost = 90, Status = OrderStatus.PaymentComplete, CustomerId = 1 },
            new Order(){ OrderId = "A20202023001", ProductId = 2, Price = 120, Cost = 100, Status = OrderStatus.PaymentComplete, CustomerId = 1 },
            new Order(){ OrderId = "A20202026002", ProductId = 3, Price = 200, Cost = 150, Status = OrderStatus.PaymentComplete, CustomerId = 1 },
            new Order(){ OrderId = "A20202024003", ProductId = 4, Price = 150, Cost = 120, Status = OrderStatus.PaymentComplete, CustomerId = 1 }
        };
        public IList<Order> GetOrderList()
        {
            return _orders;
        }
    }
}