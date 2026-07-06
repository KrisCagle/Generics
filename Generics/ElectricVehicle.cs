namespace Generics;

public class ElectricVehicle
{
    public string Name { get; set; }
    public int KilowattsNeeded { get; set; }

    public ElectricVehicle(string name, int kilowattsNeeded)
    {
        Name = name;
        KilowattsNeeded = kilowattsNeeded;
    }
}