namespace Generics;

public class GasStation : IRefuelable<GasVehicle>
{
    public int Capacity { get; set; }
    public GasStation(int capacity)
    {
        Capacity = capacity;
    }

    public void Refuel(List<GasVehicle> vehicles)
    {
        foreach(var vehicle in vehicles)
        {
            Console.WriteLine($"The {vehicle.Name} has been refueled with {vehicle.GallonsNeeded} gallons of gas");
        }
    }
}