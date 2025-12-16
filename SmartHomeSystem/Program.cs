using System;

namespace SmartHomeSystem
{
    public class Program
    {
        public static void Main()
        {
            SmartHomeController controller = new SmartHomeController();

            Light light = new Light { Name = "Лампа у вітальні" };
            AirConditioner ac = new AirConditioner { Name = "Кондиціонер у спальні" };
            CoffeeMachine coffee = new CoffeeMachine { Name = "Кавомашина на кухні" };
            MotionSensor sensor = new MotionSensor { Name = "Датчик руху у коридорі" };

            controller.AddDevice(light);
            controller.AddDevice(ac);
            controller.AddDevice(coffee);
            controller.AddDevice(sensor);

            controller.AddEnergyDevice(light);
            controller.AddEnergyDevice(ac);
            controller.AddEnergyDevice(coffee);

            controller.TurnAllOn();
            Console.WriteLine();

            light.PrintStatus();
            ac.PrintStatus();
            coffee.PrintStatus();
            sensor.PrintStatus();
            Console.WriteLine();

            controller.ShowEnergyReport(5);
            Console.WriteLine();

            controller.TurnAllOff();
        }
    }
}
