using System;
using System.Globalization;

namespace DeliverySystem
{
    public class Vehicle
    {
        protected string brand;      // марка
        protected int year;          // рік
        protected double mileage;    // пробіг (км)
        protected double maxSpeed;   // макс. швидкість (км/год)

        public Vehicle(string brand, int year, double mileage, double maxSpeed)
        {
            this.brand = brand;
            this.year = year;
            this.mileage = mileage;
            this.maxSpeed = maxSpeed;
        }

        public virtual string GetInfo()
        {
            return $"{brand} ({year}), Mileage: {Format(mileage)} km";
        }

        public virtual double GetMaxSpeed()
        {
            return maxSpeed;
        }

        public virtual void Move(double distance)
        {
            mileage += distance;
            Console.WriteLine($"{brand} drove {Format(distance)} km.");
        }

        protected string Format(double value)
        {
            return value.ToString("0.##", CultureInfo.InvariantCulture);
        }
    }
}
