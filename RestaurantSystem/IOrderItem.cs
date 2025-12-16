namespace RestaurantSystem
{
    // Інтерфейс для позицій, які можна додавати в замовлення
    public interface IOrderItem
    {
        string Name { get; }
        decimal Price { get; }
        string GetDisplayInfo();
    }
}
