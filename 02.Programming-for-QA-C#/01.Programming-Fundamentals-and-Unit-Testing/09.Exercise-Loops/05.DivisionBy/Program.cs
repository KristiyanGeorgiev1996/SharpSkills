namespace _05.DivisionBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double divisibleBy2 = 0;
            double divisibleBy3 = 0;
            double divisibleBy4 = 0;
            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber % 2 == 0)
                {
                    divisibleBy2++;
                }

                if (currentNumber % 3 == 0)
                {
                    divisibleBy3++;
                }

                if (currentNumber % 4 == 0)
                {
                    divisibleBy4++;
                }
            }

            double divisibleBy2Percentage = (divisibleBy2 / n) * 100.0;
            double divisibleBy3Percentage = (divisibleBy3 / n) * 100.0;
            double divisibleBy4Percentage = (divisibleBy4 / n) * 100.0;

            Console.WriteLine($"{divisibleBy2Percentage:F2}%");
            Console.WriteLine($"{divisibleBy3Percentage:F2}%");
            Console.WriteLine($"{divisibleBy4Percentage:F2}%");
        }
    }
}