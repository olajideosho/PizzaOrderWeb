using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PapaBobMegaChallenge;

namespace PapaBobMegaChallenge.Domain
{
    public class OrderManagement
    {
        public static List<DTO.Order> DisplayOrder()
        {
            return Persistence.OrderRepository.DisplayOrders();
        }

        public static void AddOrder(DTO.Order order)
        {
            Persistence.OrderRepository.AddOrder(order);
        }
    }
}
