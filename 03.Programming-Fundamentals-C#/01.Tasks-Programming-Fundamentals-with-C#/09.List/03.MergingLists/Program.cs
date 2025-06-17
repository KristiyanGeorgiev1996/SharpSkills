List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> result = new List<int>();

int maxHeigthList = 0;

if (numbers.Count > numbers2.Count)
{
    maxHeigthList = numbers.Count;
}
else
{
    maxHeigthList = numbers2.Count;
}

for (int i = 0; i < maxHeigthList; i++)
{
    //// result.Add(numbers[i]);
    //// result.Add(numbers2[i]);
    if (i < numbers.Count)
    {
        result.Add(numbers[i]);
    }
    if (i < numbers2.Count)
    {
        result.Add(numbers2[i]);
    }
}
Console.WriteLine(string.Join(" ", result));
