using System;

class BitAtPosition1
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int bitAtPosition1 = (n >> 1) & 1;

        Console.WriteLine(bitAtPosition1);
    }
}
