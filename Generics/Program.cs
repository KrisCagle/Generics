using Generics;

var gasVehicles = new List<GasVehicle>
{
    new GasVehicle("Cessna", 200),
    new GasVehicle("Pickup Truck", 25)
};

var electricVehicles = new List<ElectricVehicle>
{
    new ElectricVehicle("Tesla Model 3", 75),
    new ElectricVehicle("Nissan Leaf", 40)
};

var gasStation = new GasStation(capacity: 5);
var batteryStation = new BatteryStation(capacity: 3);

gasStation.Refuel(gasVehicles);
batteryStation.Refuel(electricVehicles);