using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OrderServices.Models;
using OrderServices;

namespace OrderServiceConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService testService = new OrderService();

            //var testOrder = new List<>

            string testresponse = testService.LoadOrderData();
        }
    }
}
