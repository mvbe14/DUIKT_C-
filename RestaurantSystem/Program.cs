using System;

namespace RestaurantSystem
{
    public class Program
    {
        public static void Main()
        {
            RestaurantSystemApp app = new RestaurantSystemApp();

            // 1) Меню
            app.Menu.Add(new Dish("Борщ", 120m, "Перше", 350));
            app.Menu.Add(new Drink("Кава", 60m, 200, false));
            app.Menu.Add(new Drink("Сік апельсиновий", 70m, 250, false));

            app.Menu.PrintMenu();

            // 2) Створення замовлення
            Order order = app.CreateOrder(5);

            // upcast (MenuItem -> IOrderItem), бо MenuItem реалізує інтерфейс IOrderItem
            var borsh = app.Menu.FindByName("Борщ");
            var coffee = app.Menu.FindByName("Кава");

            if (borsh != null) order.AddItem(borsh);
            if (coffee != null) order.AddItem(coffee);

            Console.WriteLine($"Поточна сума: {order.GetTotal()} грн");
            Console.WriteLine();
            Console.WriteLine($"Статус замовлення: {order.Status}");

            // 3) Зміна статусів
            order.NextStatus(); // InProgress
            order.NextStatus(); // Ready
            order.NextStatus(); // Paid
            Console.WriteLine();

            // 4) Пошук замовлення за ID
            int idToFind = order.Id;
            var found = app.FindOrderById(idToFind);
            if (found != null)
            {
                Console.WriteLine($"Знайдено замовлення за ID {idToFind}:");
                found.PrintItems();
            }

            // 5) Вивід всіх замовлень
            app.PrintAllOrders();

            // 6) Пошук позицій меню за категорією (приклад)
            var drinks = app.Menu.FindByCategory("Напій");
            Console.WriteLine("--- ПОШУК: категорія 'Напій' ---");
            foreach (var d in drinks)
                Console.WriteLine(d.GetDisplayInfo());
        }
    }
}
