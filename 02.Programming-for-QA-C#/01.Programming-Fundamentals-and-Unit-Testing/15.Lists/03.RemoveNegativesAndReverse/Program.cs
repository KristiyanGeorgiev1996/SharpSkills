
List<int> numbers = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToList();

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] < 0)
    {
        numbers.RemoveAt(i); // изтриваме елемент на даден индекс
        i--; // намаляме индеска, за да не изпуснем елемент
    }
}

// обръщаме елементите в листа в обратен ред (несортирани!!!)
numbers.Reverse();

if (numbers.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine(string.Join(" ", numbers));
}