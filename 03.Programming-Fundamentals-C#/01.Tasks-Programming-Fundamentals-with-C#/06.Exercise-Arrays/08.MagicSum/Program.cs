int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int number = int.Parse(Console.ReadLine());


for (int i = 0; i < array.Length - 1; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] + array[j] == number)
        {
            Console.WriteLine($"{array[i]} {array[j]}");
        }
    }
}