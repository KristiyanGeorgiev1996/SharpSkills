namespace _07.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            // 5 2 8
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i]; // 5
                bool isTopNumber = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nextNumber = numbers[j]; // 2
                    if (currentNumber <= nextNumber)
                    {
                        isTopNumber = false;
                        break;
                    }
                }

                if (isTopNumber)
                {
                    Console.Write($"{currentNumber} ");
                }
            }
        }
    }
}