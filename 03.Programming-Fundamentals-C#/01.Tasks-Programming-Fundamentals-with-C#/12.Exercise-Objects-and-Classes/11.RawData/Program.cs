using System;
using System.Collections.Generic;

public class Engine
{
    public int Speed { get; set; }
    public int Power { get; set; }

    public Engine(int speed, int power)
    {
        Speed = speed;
        Power = power;
    }
}

public class Cargo
{
    public int Weight { get; set; }
    public string Type { get; set; }

    public Cargo(int weight, string type)
    {
        Weight = weight;
        Type = type;
    }
}

public class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }

    public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
    {
        Model = model;
        Engine = new Engine(engineSpeed, enginePower);
        Cargo = new Cargo(cargoWeight, cargoType);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            string[] carInfo = Console.ReadLine().Split();
            string model = carInfo[0];
            int engineSpeed = int.Parse(carInfo[1]);
            int enginePower = int.Parse(carInfo[2]);
            int cargoWeight = int.Parse(carInfo[3]);
            string cargoType = carInfo[4];

            Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType);
            cars.Add(car);
        }

        string command = Console.ReadLine();
        if (command == "fragile")
        {
            foreach (var car in cars)
            {
                if (car.Cargo.Type == "fragile" && car.Cargo.Weight < 1000)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
        else if (command == "flamable")
        {
            foreach (var car in cars)
            {
                if (car.Cargo.Type == "flamable" && car.Engine.Power > 250)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
