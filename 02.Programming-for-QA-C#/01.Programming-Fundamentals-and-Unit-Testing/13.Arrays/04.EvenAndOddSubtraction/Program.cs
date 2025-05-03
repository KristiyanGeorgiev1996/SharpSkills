
int[] numbers = Console.ReadLine()
                       .Split(" ")
                       .Select(int.Parse)
                       .ToArray();

int evenSum = 0;
int oddSum = 0;

foreach (var num in numbers)
{
    if (num % 2 == 0)
    {
        evenSum += num;
    }
    else
    {
        oddSum += num;
    }
}

Console.WriteLine(evenSum - oddSum);