using System;

public class Program
{
    public static void Main()
    {
        //Data Types and Variables - More Exercise - 04. Refactoring: Prime Checker

        int n = int.Parse(Console.ReadLine());
        for (int i = 2; i <= n; i++)
        {
            bool isPrime = true;
            for (int devider = 2; devider < i; devider++)
            {
                if (i % devider == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{i} -> true");
            }
            else
            {
                Console.WriteLine($"{i} -> false");
            }
        }
    }
}