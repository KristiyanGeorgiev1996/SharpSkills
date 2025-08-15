using System;

class BitAtPositionP
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int bitAtP = (n >> p) & 1;

        Console.WriteLine(bitAtP);
    }
}
