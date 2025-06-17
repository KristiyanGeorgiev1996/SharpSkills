using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        StringRandomizer randomizer = new StringRandomizer();

        randomizer.Input = Console.ReadLine();
        randomizer.RandomizeInput();

        foreach (var item in randomizer.RandomizerInput)
        {
            Console.WriteLine(item);
        }
    }
}

class StringRandomizer
{
    public string Input { get; set; }
    public List<string> RandomizerInput { get; private set; }

    public void RandomizeInput()
    {
        RandomizerInput = new List<string>();
        List<string> splitted = Input.Split(" ").ToList();
        int count = splitted.Count;
        Random random = new Random();

        for (int i = 0; i < count; i++)
        {
            int index = random.Next(0, splitted.Count);
            RandomizerInput.Add(splitted[index]);
            splitted.RemoveAt(index);
        }
    }
}
