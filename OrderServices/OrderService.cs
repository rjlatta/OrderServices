using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;



using OrderServices.Models;

namespace OrderServices
{
    public class OrderService
    {
        private List<Order> tempListOfOrders = new List<Order>();
        public string LoadOrderData()
        {
            //load data from text file. convert from json to objects, load page with info
            //string text = System.IO.File.ReadAllText(@"C:\Users\rlatta\Documents\StoredOrders.txt");
            string text2;
            using (StreamReader sr = new StreamReader(@"C:\Users\rlatta\Documents\StoredOrders.txt", Encoding.UTF8))
            {
                text2 = sr.ReadToEnd();
            }

            //string text3 = text2.Replace(@"\", "");

            //var test = JsonConvert.DeserializeObject<OrdersContainer>(text);

            var test2 = JsonConvert.DeserializeObject<OrdersContainer>(text2);

            return text2;
        }

        public void CreateNewOrder(string name, string address)
        {
            //create new order.
        }

        public void DeleteOrder()
        {
        }

        public void ModifyOrder()
        {
        }

        public void StoreOrder()
        {
        }

    }
}
