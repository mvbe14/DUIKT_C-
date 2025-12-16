namespace RestaurantSystem
{
    public class Drink : MenuItem
    {
        public int VolumeMl { get; }
        public bool IsAlcoholic { get; }

        public Drink(string name, decimal price, int volumeMl, bool isAlcoholic)
            : base(name, price, "Напій")
        {
            VolumeMl = volumeMl;
            IsAlcoholic = isAlcoholic;
        }

        public override string GetDisplayInfo()
        {
            string alcText = IsAlcoholic ? "алкоголь" : "без алкоголю";
            return $"{Name} ({VolumeMl} мл, {alcText}) - {Price} грн";
        }
    }
}
