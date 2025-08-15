using System;
using System.Linq;

class SumEvenNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separated by space:");
        int[] numbers = Console.ReadLine()
                               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

        int sumEven = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                sumEven += number;
            }
        }

        Console.WriteLine($"Sum of even numbers: {sumEven}");
    }
}
