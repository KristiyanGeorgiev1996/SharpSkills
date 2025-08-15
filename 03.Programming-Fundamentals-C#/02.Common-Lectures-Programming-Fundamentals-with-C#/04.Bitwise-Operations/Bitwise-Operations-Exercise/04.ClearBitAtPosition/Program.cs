using System;

class ClearBit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int mask = ~(1 << p);
        int newNumber = n & mask;

        Console.WriteLine(newNumber);
    }
}
