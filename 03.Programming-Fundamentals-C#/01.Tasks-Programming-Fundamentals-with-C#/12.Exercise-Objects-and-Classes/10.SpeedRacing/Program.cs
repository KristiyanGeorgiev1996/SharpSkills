using System;
using System.Collections.Generic;
using System.Linq;

class Car
{
    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumptionPerKm { get; set; }
    public double TraveledDistance { get; set; }

    public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumptionPerKm = fuelConsumptionPerKm;
        TraveledDistance = 0;
    }

    public bool Drive(double amountOfKm)
    {
        double neededFuel = amountOfKm * FuelConsumptionPerKm;
        if (neededFuel <= FuelAmount)
        {
            FuelAmount -= neededFuel;
            TraveledDistance += amountOfKm;
            return true;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
            return false;
        }
    }
}
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        Dictionary<string, Car> cars = new Dictionary<string, Car>();

        for (int i = 0; i < N; i++)
        {
            string[] carInfo = Console.ReadLine().Split();
            string model = carInfo[0];
            double fuelAmount = double.Parse(carInfo[1]);
            double fuelConsumptionPerKm = double.Parse(carInfo[2]);

            if (!cars.ContainsKey(model))
            {
                Car car = new Car(model, fuelAmount, fuelConsumptionPerKm);
                cars.Add(model, car);
            }
        }

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] commandParts = command.Split();
            string carModel = commandParts[1];
            double amountOfKm = double.Parse(commandParts[2]);

            if (cars.ContainsKey(carModel))
            {
                cars[carModel].Drive(amountOfKm);
            }
        }

        foreach (var car in cars.Values)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TraveledDistance}");
        }
    }
}
