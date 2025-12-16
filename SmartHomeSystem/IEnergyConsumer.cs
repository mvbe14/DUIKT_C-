namespace SmartHomeSystem
{
    public interface IEnergyConsumer
    {
        string DeviceName { get; }
        int PowerConsumption { get; } // Вт
        double GetEnergyUsage(int hours); // кВт·год
    }
}
