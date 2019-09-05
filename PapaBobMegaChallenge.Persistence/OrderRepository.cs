using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobMegaChallenge.Persistence
{
    public class OrderRepository
    {

        public static List<DTO.Order> DisplayOrders()
        {
            var db = new OrdersDBEntities();
            var dbOrders = db.Orders;
            var dtoOrders = new List<DTO.Order>();

            foreach(var order in dbOrders)
            {
                var newOrder = new DTO.Order();

                newOrder.OrderId = order.OrderId;
                newOrder.Size = order.Size;
                newOrder.Crust = order.Crust;
                newOrder.Extras = order.Extras;
                newOrder.Name = order.Name;
                newOrder.Address = order.Address;
                newOrder.Zip = order.Zip;
                newOrder.Phone = order.Phone;
                newOrder.PayType = order.PayType;
                newOrder.Price = order.Price;

                dtoOrders.Add(newOrder);
            }

            return dtoOrders;
        }

        public static void AddOrder(DTO.Order order)
        {
            var db = new OrdersDBEntities();
            var dbOrders = db.Orders;
            var newOrder = new Order();

            newOrder.OrderId = Guid.NewGuid();
            newOrder.Size = order.Size;
            newOrder.Crust = order.Crust;
            newOrder.Extras = order.Extras;
            newOrder.Name = order.Name;
            newOrder.Address = order.Address;
            newOrder.Zip = order.Zip;
            newOrder.Phone = order.Phone;
            newOrder.PayType = order.PayType;
            newOrder.Price = order.Price;

            dbOrders.Add(newOrder);
            db.SaveChanges();
                
        }

    }
}
