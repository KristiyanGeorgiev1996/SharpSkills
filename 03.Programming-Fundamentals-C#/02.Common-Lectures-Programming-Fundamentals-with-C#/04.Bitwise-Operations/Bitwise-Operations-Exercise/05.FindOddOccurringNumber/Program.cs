using System;
using System.Linq;

class OddTimes
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
                               .Split(' ')
                               .Select(int.Parse)
                               .ToArray();

        int result = 0;
        foreach (int num in numbers)
        {
            result ^= num;
        }

        Console.WriteLine(result);
    }
}
