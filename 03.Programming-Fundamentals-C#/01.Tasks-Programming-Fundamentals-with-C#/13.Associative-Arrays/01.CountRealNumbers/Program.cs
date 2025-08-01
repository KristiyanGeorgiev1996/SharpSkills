﻿double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

foreach (var number in numbers)
{
    if (counts.ContainsKey(number))
    {
        counts[number]++;
    }
    else
    {
        counts.Add(number, 1);
    }
}

foreach (var number in counts)
{
    Console.WriteLine($"{number.Key} -> {number.Value}");
}