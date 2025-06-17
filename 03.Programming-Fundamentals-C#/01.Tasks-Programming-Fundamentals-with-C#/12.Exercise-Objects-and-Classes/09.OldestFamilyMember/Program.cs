using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Family
{
    private List<Person> people;

    public Family()
    {
        people = new List<Person>();
    }

    public void AddMember(Person member)
    {
        people.Add(member);
    }

    public Person GetOldestMember()
    {
        return people.OrderByDescending(p => p.Age).FirstOrDefault();
    }
}

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        Family family = new Family();

        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            string name = input[0];
            int age = int.Parse(input[1]);
            Person person = new Person(name, age);
            family.AddMember(person);
        }

        Person oldest = family.GetOldestMember();
        if (oldest != null)
        {
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
