using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }

            string[] vehicleData = input.Split();
            string type = vehicleData[0];
            string model = vehicleData[1];
            string color = vehicleData[2];
            int horsepower = int.Parse(vehicleData[3]);

            Vehicle vehicle = new Vehicle(type, model, color, horsepower);
            vehicles.Add(vehicle);
        }

        List<string> requestedModels = new List<string>();
        while (true)
        {
            string command = Console.ReadLine();
            if (command == "Close the Catalogue")
            {
                break;
            }
            requestedModels.Add(command);
        }

        List<Vehicle> requestedVehicles = vehicles.Where(v => requestedModels.Contains(v.Model)).ToList();

        List<Vehicle> cars = requestedVehicles.Where(v => v.Type == "car").OrderBy(v => v.Horsepower).ToList();
        List<Vehicle> trucks = requestedVehicles.Where(v => v.Type == "truck").OrderBy(v => v.Horsepower).ToList();

        foreach (var car in cars)
        {
            Console.WriteLine($"Type: Car");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Color: {car.Color}");
            Console.WriteLine($"Horsepower: {car.Horsepower}");
        }

        foreach (var truck in trucks)
        {
            Console.WriteLine($"Type: Truck");
            Console.WriteLine($"Model: {truck.Model}");
            Console.WriteLine($"Color: {truck.Color}");
            Console.WriteLine($"Horsepower: {truck.Horsepower}");
        }

        List<Vehicle> allCars = vehicles.Where(v => v.Type == "car").ToList();
        List<Vehicle> allTrucks = vehicles.Where(v => v.Type == "truck").ToList();

        double averageCarsHorsepower = CalculateAverageHorsepower(allCars);
        double averageTrucksHorsepower = CalculateAverageHorsepower(allTrucks);

        Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsepower:F2}.");
        Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsepower:F2}.");
    }

    static double CalculateAverageHorsepower(List<Vehicle> vehicles)
    {
        if (vehicles.Count == 0)
        {
            return 0;
        }

        double totalHorsepower = vehicles.Sum(v => v.Horsepower);
        return totalHorsepower / vehicles.Count;
    }

    static string Capitalize(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }

        return char.ToUpper(text[0]) + text.Substring(1);
    }
}

class Vehicle
{
    public string Type { get; }
    public string Model { get; }
    public string Color { get; }
    public int Horsepower { get; }

    public Vehicle(string type, string model, string color, int horsepower)
    {
        Type = type;
        Model = model;
        Color = color;
        Horsepower = horsepower;
    }
}
