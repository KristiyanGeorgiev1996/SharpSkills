using System;
using System.Collections.Generic;

namespace MiniConsoleManager
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public Person(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            people.Add(new Person("Alice", 25, "Sofia"));
            people.Add(new Person("Bob", 30, "Plovdiv"));
            people.Add(new Person("Charlie", 22, "Varna"));

            Console.WriteLine("All persons:");
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age} years old, from {person.City}");
            }

            people[0].Age = 26;
            Console.WriteLine("\nAfter editing Alice's age:");
            Console.WriteLine($"{people[0].Name}, {people[0].Age} years old, from {people[0].City}");

            people.RemoveAt(1); 
            Console.WriteLine("\nAfter removing Bob:");
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age} years old, from {person.City}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
