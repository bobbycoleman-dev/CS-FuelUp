abstract class Vehicle
{
    public string Name { get; set; }
    public int Passengers;
    public string Color;
    public bool HasEngine;
    public int MilesTraveled = 0;

    public Vehicle(string name, int passengers, string color, bool hasEngine)
    {
        Name = name;
        Passengers = passengers;
        Color = color;
        HasEngine = hasEngine;
    }

    public Vehicle(string name, string color)
    {
        Name = name;
        Color = color;
        Passengers = 2;
        HasEngine = true;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}\nPassengers: {Passengers}\nColor: {Color}\nHas Engine: {HasEngine}\nMiles Traveled: {MilesTraveled}\n");
    }

    public void Travel(int distance)
    {
        MilesTraveled += distance;
        Console.WriteLine($"The vehicle has traveled {MilesTraveled} miles.");
    }
}