List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> result = new List<int>();

for (int i = 0; i < numbers.Count / 2; i++)
{
    int currentResult = numbers[i] + numbers[numbers.Count - 1 - i];
    result.Add(currentResult);
}
if (numbers.Count % 2 == 1)
{
    result.Add(numbers[numbers.Count / 2]);
}


Console.WriteLine(string.Join(" ", result));