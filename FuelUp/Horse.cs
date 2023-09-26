class Horse : Vehicle, INeedFuel
{
    public string FuelType { get; set; }
    public int FuelTotal { get; set; } = 10;

    public Horse(string name, string color, string fuel)
    : base(name, 1, color, false)
    {
        FuelType = fuel;
    }

    public void GiveFuel(int Amount)
    {
        FuelTotal += Amount;
        Console.WriteLine($"You fed your horse {Amount} {FuelType}. The horse now has {FuelTotal} gallons of food in its stomach.");
    }
}