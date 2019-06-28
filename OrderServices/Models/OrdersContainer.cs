using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServices.Models
{
    class OrdersContainer
    {
        List<Order> Orders { get; set; }

        public OrdersContainer()
        {
            Orders = new List<Order>();
        }
            

    }
}
