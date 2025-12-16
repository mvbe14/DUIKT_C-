using System;
using System.Collections.Generic;

namespace RestaurantSystem
{
    public class RestaurantMenu
    {
        private readonly List<MenuItem> items = new();

        public void Add(MenuItem item) => items.Add(item);

        public void PrintMenu()
        {
            Console.WriteLine("--- МЕНЮ РЕСТОРАНУ ---");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].GetDisplayInfo()}");
            }
            Console.WriteLine();
        }

        public MenuItem? FindByName(string name)
        {
            foreach (var item in items)
            {
                if (item.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return item;
            }
            return null;
        }

        public List<MenuItem> FindByCategory(string category)
        {
            List<MenuItem> result = new();
            foreach (var item in items)
            {
                if (item.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                    result.Add(item);
            }
            return result;
        }
    }
}
