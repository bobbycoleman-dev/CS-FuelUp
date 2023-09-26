class Car : Vehicle, INeedFuel
{
    public string FuelType { get; set; }
    public int FuelTotal { get; set; } = 10;

    public Car(string name, int passengers, string color, bool hasEngine, string fuel)
    : base(name, passengers, color, hasEngine)
    {
        FuelType = fuel;
    }

    public void GiveFuel(int Amount)
    {
        FuelTotal += Amount;
        Console.WriteLine($"Filled the car with {Amount} {(FuelType == "gas" || FuelType == "diesel" ? "gallons" : "watts")} of {FuelType}. The car now has {FuelTotal} {(FuelType == "gas" || FuelType == "diesel" ? "gallons" : "watts")} of {FuelType}.");
    }
}