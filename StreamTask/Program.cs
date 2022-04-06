
using Newtonsoft.Json;
using StreamTask.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace StreamTask
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Serialize
            //Product smoke = new Product { Id = 1, Name = "Winston", Price = 3.5 };
            //Product bread = new Product { Id = 2, Name = "Nur", Price = 0.5 };
            //Product beer = new Product { Id = 3, Name = "Nzs", Price = 1.5 };
            //Product milk = new Product { Id = 3, Name = "Milla", Price = 1.5 };
            //OrderItem item1 = new OrderItem { Id = 1, Product = smoke, Count = 1 };
            //item1.TotalPrice = smoke.Price * item1.Count;

            //OrderItem item2 = new OrderItem { Id = 2, Product = bread, Count = 2, TotalPrice = bread.Price * 2 };
            //item2.TotalPrice = bread.Price * item2.Count;

            //OrderItem item3 = new OrderItem { Id = 3, Product = beer, Count = 4, TotalPrice = beer.Price * 4 };
            //item3.TotalPrice = beer.Price * item3.Count;

            //OrderItem item4 = new OrderItem { Id = 4, Product = milk, Count = 1, TotalPrice = milk.Price * 1 };
            //item4.TotalPrice = milk.Price * item4.Count;
            //List<OrderItem> orderItems1 = new List<OrderItem>();
            //orderItems1.Add(item1);
            //orderItems1.Add(item2);
            //orderItems1.Add(item3);
            //orderItems1.Add(item4);
            //Order order1 = new Order { Id = 1, OrderItems = orderItems1 };

            //var jsonObj = JsonConvert.SerializeObject(order1);
            //Console.WriteLine(jsonObj);
            //using (StreamWriter sw = new StreamWriter(@"C:\Users\tu4pw6wq5\source\repos\StreamTask\StreamTask\Files\json1.json"))
            //{
            //    sw.WriteLine(jsonObj);
            //}
            #endregion
            #region Deserialize
            string result;
            using (StreamReader sr = new StreamReader(@"C:\Users\tu4pw6wq5\source\repos\StreamTask\StreamTask\Files\json1 (1).json"))
            {
                result = sr.ReadToEnd();
            }
            Order o1 = JsonConvert.DeserializeObject<Order>(result);

            foreach (var item in o1.OrderItems)
            {
                Console.WriteLine($"Id :{item.Id} Name : {item.Product.Name} TotalPrice : {item.TotalPrice} price : {item.Product.Price}");
            }
            
            #endregion
        }
    }
}
