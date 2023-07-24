using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterItensByItsChilds_AnotherList // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var orders = new List<int> { 2, 3 };
            var items = GetPOCOsAndOrders();

            var peopleAndOrdersWhereOrderNumberIsGreaterThanTwo = items.Where(x => x.Orders.Any(y => orders.Contains(y.Id)));

            //I should only get the last two people out of three and their orders
            peopleAndOrdersWhereOrderNumberIsGreaterThanTwo.ToList().ForEach(x => Console.WriteLine($"{x.Id} {x.Desc} {x.Orders.Count}"));

            Console.ReadLine();
        }


        public class POC
        {
            public int Id { get; set; }
            public string Desc { get; set; }
            public List<Order> Orders { get; set; }
        }

        public class Order
        {
            public int Id { get; set; }
            public string Desc { get; set; }
        }

        static List<Order> GetOrders(int numberOfOrders)
        {
            var orders = new List<Order>();

            for (int i = 1; i <= numberOfOrders; i++)
            {
                orders.Add(new Order { Id = i, Desc = $"{i} Order" });
            }

            return orders;
        }

        static List<POC> GetPOCOsAndOrders()
        {
            return new List<POC>
              {
                  new POC { Id = 1, Desc = "John", Orders = GetOrders(1)},
                  new POC { Id = 2, Desc = "Jane", Orders = GetOrders(2) },
                  new POC { Id = 3, Desc = "Joey" , Orders = GetOrders(3)}
              };
        }


    }
}