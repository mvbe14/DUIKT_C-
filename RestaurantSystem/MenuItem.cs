namespace RestaurantSystem
{
    public abstract class MenuItem : IOrderItem
    {
        public string Name { get; }
        public decimal Price { get; }
        public string Category { get; } // категорія: "Перше", "Напій", ...

        protected MenuItem(string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        // Для красивого виводу в меню
        public abstract string GetDisplayInfo();
    }
}
