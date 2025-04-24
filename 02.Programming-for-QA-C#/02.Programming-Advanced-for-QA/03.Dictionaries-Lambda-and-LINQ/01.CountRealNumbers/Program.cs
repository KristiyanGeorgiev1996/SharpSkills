
List<double> numbers = Console.ReadLine()
                           .Split(' ')
                           .Select(double.Parse)
                           .ToList();

SortedDictionary<double, int> numbersWithOccurrences = new();

foreach (var number in numbers)
{
    if (numbersWithOccurrences.ContainsKey(number))
    {
        numbersWithOccurrences[number] += 1;
    }
    else
    {
        numbersWithOccurrences.Add(number, 1);
    }
}

foreach (KeyValuePair<double, int> kvp in numbersWithOccurrences)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}