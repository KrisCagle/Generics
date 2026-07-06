namespace Generics;

public class GasVehicle
{
    public string Name { get; set; }
    public int GallonsNeeded { get; set; }

    public GasVehicle(string name, int gallonsNeeded)
    {
        Name = name;
        GallonsNeeded = gallonsNeeded;
    }
}