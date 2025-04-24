using System.Reflection;

namespace _04.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Cataloge vehiclesCatalog = new Cataloge();

            while (input != "end")
            {
                string[] tokens = input.Split("/");
                string typeVehicle = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];
                int hpOrWeight = int.Parse(tokens[3]);

                if (typeVehicle == "Truck")
                {
                    Truck truck = new Truck(brand, model, hpOrWeight);

                    vehiclesCatalog.Truks.Add(truck);
                }
                else if (typeVehicle == "Car")
                {
                    Car car = new Car(brand, model, hpOrWeight);

                    vehiclesCatalog.Cars.Add(car);
                }

                input = Console.ReadLine();
            }

            if (vehiclesCatalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (var car in vehiclesCatalog.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (vehiclesCatalog.Truks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (var truck in vehiclesCatalog.Truks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }

    }

    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    public class Cataloge
    {
        public List<Truck> Truks { get; set; } = new List<Truck>();

        public List<Car> Cars { get; set; } = new List<Car>();
    }
}