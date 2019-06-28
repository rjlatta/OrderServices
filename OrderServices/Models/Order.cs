using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServices.Models
{
    class Order
    {
        public Customer customer { get; set; }

        //public DateTime creationDate { get; set; }

        //public DateTime deliveryDate { get; set; }

       // public List<Product> orderList { get; set; }

        public Order()
        {
            customer = new Customer();

            //orderList = new List<Product>();
        }
    }
}
