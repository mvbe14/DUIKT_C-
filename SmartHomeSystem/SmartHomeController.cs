using System;
using System.Collections.Generic;
using System.Globalization;

namespace SmartHomeSystem
{
    public class SmartHomeController
    {
        private readonly List<ISwitchable> switchables = new();
        private readonly List<IEnergyConsumer> energyDevices = new();

        public void AddDevice(ISwitchable device)
        {
            switchables.Add(device);
        }

        public void AddEnergyDevice(IEnergyConsumer device)
        {
            energyDevices.Add(device);
        }

        public void TurnAllOn()
        {
            foreach (var d in switchables)
                d.TurnOn();
        }

        public void TurnAllOff()
        {
            foreach (var d in switchables)
                d.TurnOff();
        }

        public void ShowEnergyReport(int hours)
        {
            var ua = new CultureInfo("uk-UA");

            Console.WriteLine($"Звіт про споживання енергії за {hours} год:");

            double total = 0;
            foreach (var d in energyDevices)
            {
                double usage = d.GetEnergyUsage(hours);
                total += usage;

                Console.WriteLine(
                    $"{d.DeviceName}: {usage.ToString("0.00", ua)} кВт·год (потужність: {d.PowerConsumption} Вт)"
                );
            }

            Console.WriteLine($"Загальне споживання: {total.ToString("0.00", ua)} кВт·год");

            double cost = total * 4.0;
            Console.WriteLine($"Вартість (~4 грн/кВт·год): {cost.ToString("0.00", ua)} грн");
        }
    }
}
