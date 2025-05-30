int numbersOfRead = int.Parse(Console.ReadLine());

int[] arr1 = new int[numbersOfRead];
int[] arr2 = new int[numbersOfRead];

for (int i = 0; i < numbersOfRead; i++)
{
    int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int k = 0; k < numbers.Length; k++)
    {
        if (i == 0)
        {
            arr1[0] = numbers[0];
            arr2[0] = numbers[1];
        }
        else if (i == 1)
        {
            arr1[1] = numbers[1];
            arr2[1] = numbers[0];
        }
        else if (i == 2)
        {
            arr1[2] = numbers[0];
            arr2[2] = numbers[1];
        }
        else if (i == 3)
        {
            arr1[3] = numbers[1];
            arr2[3] = numbers[0];
        }
        else if (i == 4)
        {
            arr1[4] = numbers[0];
            arr2[4] = numbers[1];
        }
    }
}
for (int i = 0; i < arr1.Length; i++)
{
    if (i == arr1.Length - 1)
    {
        Console.Write(arr1[i]);
    }
    else
    {
        Console.Write(arr1[i] + " ");
    }
}
Console.WriteLine();
for (int i = 0; i < arr2.Length; i++)
{
    if (i == arr2.Length - 1)
    {
        Console.Write(arr2[i]);
    }
    else
    {
        Console.Write(arr2[i] + " ");
    }
}

