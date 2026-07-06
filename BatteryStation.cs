namespace Generics;

public class BatteryStation : IRefuelable<ElectricVehicle>
{
     public int Capacity { get; set; }
     public BatteryStation(int capacity)
    {
        Capacity = capacity;
    }
    public void Refuel(List<ElectricVehicle> vehicles)
    {
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"The {vehicle.Name} has been charged with {vehicle.KilowattsNeeded} kilowatts of power");
        }
    }
}