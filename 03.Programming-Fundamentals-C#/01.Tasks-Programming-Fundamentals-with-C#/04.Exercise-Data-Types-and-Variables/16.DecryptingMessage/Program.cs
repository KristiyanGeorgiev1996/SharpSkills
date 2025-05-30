using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int key = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    char input = char.Parse(Console.ReadLine());

                    int shifted = (int)input + key;

                    Console.Write((char)shifted);
                }
            }
        }
    }
}