﻿namespace _02.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }
}