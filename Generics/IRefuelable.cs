namespace Generics;

public interface IRefuelable<T>
{
    int Capacity { get; set; }
    void Refuel(List<T> vehicles);
} 