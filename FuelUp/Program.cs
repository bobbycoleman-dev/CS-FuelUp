// 1. Make instances of Car, Horse, Bike
Car MyCar = new("Sierra 1500", 5, "Black", true, "diesel");
Horse Biscuit = new("Biscuit", "Brown with White Speckles", "Hay");
Bike Schwin = new("Schwin", 1, "Red", false);

// 2. Try to make instance of Vehicle
// Vehicle MyVehicle = new("Vehicle", 4, "Blue", true)
// Unable to make an instance of a Vehicle because it is as abstract class

// 3. Create List of Vehicles
List<Vehicle> VehicleList = new() { MyCar, Biscuit, Schwin };

// 4. Make list of type INeedFuel
List<INeedFuel> NeedsFuelList = new();

// 5. Loop thru Vehicles List to add to NeedsFuelList
foreach (Vehicle v in VehicleList)
{
    if (v is INeedFuel f)
    {
        NeedsFuelList.Add(f);
    }
}

// 6. Loop thru NeedsFuelList and give 10 units of fuel
foreach (INeedFuel v in NeedsFuelList)
{
    v.GiveFuel(10);
}

// 7. Loop through Vehicle List to Display Fuel levels
foreach (INeedFuel f in NeedsFuelList)
{
    if (f is Vehicle v)
    {
        Console.WriteLine($"{v.Name} has {f.FuelTotal} fuel");
    }
}
