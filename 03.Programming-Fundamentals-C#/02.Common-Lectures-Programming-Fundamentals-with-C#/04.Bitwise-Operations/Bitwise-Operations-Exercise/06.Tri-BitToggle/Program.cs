using System;

class TriBitSwitch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int mask = 7 << p; // 111 shifted to position p
        int result = n ^ mask;

        Console.WriteLine(result);
    }
}
