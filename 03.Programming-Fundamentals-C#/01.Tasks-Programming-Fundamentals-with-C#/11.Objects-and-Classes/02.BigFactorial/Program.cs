using System;
using System.Numerics; // Required for handling large numbers

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(N));
    }

    static BigInteger Factorial(int n)
    {
        BigInteger result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}
