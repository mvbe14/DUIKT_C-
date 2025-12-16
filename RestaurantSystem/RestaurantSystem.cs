using System;
using System.Collections.Generic;

namespace RestaurantSystem
{
    public class RestaurantSystemApp
    {
        public RestaurantMenu Menu { get; } = new RestaurantMenu();
        private readonly List<Order> orders = new();

        public Order CreateOrder(int tableNumber)
        {
            Order order = new Order(tableNumber);
            orders.Add(order);
            Console.WriteLine($"Створено нове замовлення для столика №{tableNumber}");
            Console.WriteLine();
            return order;
        }

        public Order? FindOrderById(int id)
        {
            foreach (var order in orders)
                if (order.Id == id) return order;

            return null;
        }

        public void PrintAllOrders()
        {
            Console.WriteLine("--- УСІ ЗАМОВЛЕННЯ ---");
            foreach (var o in orders)
                o.PrintShortInfo();
            Console.WriteLine();
        }
    }
}
