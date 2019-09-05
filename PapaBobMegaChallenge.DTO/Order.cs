using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobMegaChallenge.DTO
{
    public class Order
    {
        public System.Guid OrderId { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }
        public string Extras { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string PayType { get; set; }
        public string Price { get; set; }
    }
}
