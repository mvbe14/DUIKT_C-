namespace RestaurantSystem
{
    public class Dish : MenuItem
    {
        public int WeightGrams { get; } // додаткова характеристика

        public Dish(string name, decimal price, string category, int weightGrams)
            : base(name, price, category)
        {
            WeightGrams = weightGrams;
        }

        public override string GetDisplayInfo()
        {
            return $"{Name} ({Category}, {WeightGrams} г) - {Price} грн";
        }
    }
}
