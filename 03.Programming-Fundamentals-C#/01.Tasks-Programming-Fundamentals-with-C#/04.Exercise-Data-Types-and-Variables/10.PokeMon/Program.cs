using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int restPower = power;
            int targetsCount = 0;

            while (restPower >= distance)
            {
                if (restPower == power * 0.5 && exhaustionFactor != 0)
                {
                    restPower /= exhaustionFactor;
                }
                if (restPower < distance)
                {
                    break;
                }
                restPower -= distance;
                targetsCount++;
            }
            Console.WriteLine(restPower);
            Console.WriteLine(targetsCount);
        }
    }
}
