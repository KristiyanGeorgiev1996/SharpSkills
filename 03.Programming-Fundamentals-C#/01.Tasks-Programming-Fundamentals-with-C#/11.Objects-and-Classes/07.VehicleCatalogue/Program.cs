using System;
using System.Reflection;

List<Car> cars = new List<Car>();
List<Truck> trucks = new List<Truck>();

while (true)
{
    string command = Console.ReadLine();
    if (command == "end")
    {
        break;
    }
    else
    {
        string[] commandArray = command.Split("/");
        if (commandArray[0] == "Car")
        {
            ////Brand, Model, and Horse Power.
            Car car = new Car();
            string brand = commandArray[1];
            string model = commandArray[2];
            string HP = commandArray[3];

            car.Brand = brand;
            car.Model = model;
            car.HorsePower = HP;
            cars.Add(car);
        }
        else if (commandArray[0] == "Truck")
        {
            /////Brand, Model, and Weight
            Truck truck = new Truck();
            string brand = commandArray[1];
            string model = commandArray[2];
            string weight = commandArray[3];

            truck.Brand = brand;
            truck.Model = model;
            truck.Weight = weight;
            trucks.Add(truck);
        }
    }
}

List<Car> sortedCars = cars.OrderBy(p => p.Brand).ToList();
List<Truck> sortedTrucks = trucks.OrderBy(p => p.Brand).ToList();


if (cars.Count >= 1)
{
    Console.WriteLine("Cars:");
}
foreach (Car car in sortedCars)
{
    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
}
if (trucks.Count >= 1)
{
    Console.WriteLine("Trucks:");
}
foreach (Truck truck in sortedTrucks)
{
    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
}

public class Truck
{
    ///Brand, Model, and Weight.
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Weight { get; set; }
}
public class Car
{
    ////Brand, Model, and Horse Power.
    public string Brand { get; set; }
    public string Model { get; set; }
    public string HorsePower { get; set; }
}