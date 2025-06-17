using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public decimal Money { get; set; }
    public List<Product> Bag { get; set; }

    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        Bag = new List<Product>();
    }

    public bool BuyProduct(Product product)
    {
        if (Money >= product.Cost)
        {
            Bag.Add(product);
            Money -= product.Cost;
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class Product
{
    public string Name { get; set; }
    public decimal Cost { get; set; }

    public Product(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var people = new Dictionary<string, Person>();
        var products = new Dictionary<string, Product>();

        // Read people
        string[] peopleInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
        foreach (var personData in peopleInput)
        {
            string[] personInfo = personData.Split('=');
            string name = personInfo[0];
            decimal money = decimal.Parse(personInfo[1]);
            people[name] = new Person(name, money);
        }

        // Read products
        string[] productsInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
        foreach (var productData in productsInput)
        {
            string[] productInfo = productData.Split('=');
            string name = productInfo[0];
            decimal cost = decimal.Parse(productInfo[1]);
            products[name] = new Product(name, cost);
        }

        // Process purchase commands
        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] commandInfo = command.Split();
            string personName = commandInfo[0];
            string productName = commandInfo[1];

            if (people.ContainsKey(personName) && products.ContainsKey(productName))
            {
                Person person = people[personName];
                Product product = products[productName];

                if (person.BuyProduct(product))
                {
                    Console.WriteLine($"{personName} bought {productName}");
                }
                else
                {
                    Console.WriteLine($"{personName} can't afford {productName}");
                }
            }
        }

        // Print the results
        foreach (var person in people.Values)
        {
            if (person.Bag.Count == 0)
            {
                Console.WriteLine($"{person.Name} - Nothing bought");
            }
            else
            {
                Console.WriteLine($"{person.Name} - {string.Join(", ", person.Bag.Select(p => p.Name))}");
            }
        }
    }
}
