int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

int sumOfAllNumbers = 0;
int n = 0;

for (int i = 0; i < array1.Length; i++)
{
    if (array1[i] != array2[i])
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        break;
    }
    else
    {
        n++;
        sumOfAllNumbers += array1[i];
    }
}
if (n == array1.Length)
{
    Console.WriteLine($"Arrays are identical. Sum: {sumOfAllNumbers}");
}


