using System;

class CountBinaryDigits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        string binary = Convert.ToString(n, 2);
        int count = 0;

        foreach (char c in binary)
        {
            if (c == b.ToString()[0])
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}
