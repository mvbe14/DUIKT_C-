using System;
using System.Collections.Generic;

namespace RestaurantSystem
{
    public class Order
    {
        private static int nextId = 100;

        public int Id { get; }
        public int TableNumber { get; }
        public OrderStatus Status { get; private set; }

        private readonly List<IOrderItem> items = new();

        public Order(int tableNumber)
        {
            Id = ++nextId; // 101, 102, ...
            TableNumber = tableNumber;
            Status = OrderStatus.New;
        }

        public void AddItem(IOrderItem item)
        {
            items.Add(item);
            Console.WriteLine($"Додано позицію: {item.Name}");
        }

        public void RemoveItem(string name)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Видалено позицію: {items[i].Name}");
                    items.RemoveAt(i);
                    return;
                }
            }
            Console.WriteLine("Позицію не знайдено для видалення.");
        }

        public decimal GetTotal()
        {
            decimal sum = 0;
            foreach (var item in items)
                sum += item.Price;

            return sum;
        }

        public void PrintShortInfo()
        {
            Console.WriteLine($"ID: {Id} | Стіл: {TableNumber} | Статус: {Status} | Сума: {GetTotal()} грн");
        }

        public void PrintItems()
        {
            Console.WriteLine($"Замовлення #{Id} (стіл {TableNumber})");
            foreach (var item in items)
                Console.WriteLine($"- {item.GetDisplayInfo()}");
            Console.WriteLine($"Поточна сума: {GetTotal()} грн");
            Console.WriteLine();
        }

        // Зміна статусу в заданому порядку: New -> InProgress -> Ready -> Paid
        public void NextStatus()
        {
            if (Status == OrderStatus.New) Status = OrderStatus.InProgress;
            else if (Status == OrderStatus.InProgress) Status = OrderStatus.Ready;
            else if (Status == OrderStatus.Ready) Status = OrderStatus.Paid;

            Console.WriteLine($"> Змінено статус: {Status}");
        }
    }
}
