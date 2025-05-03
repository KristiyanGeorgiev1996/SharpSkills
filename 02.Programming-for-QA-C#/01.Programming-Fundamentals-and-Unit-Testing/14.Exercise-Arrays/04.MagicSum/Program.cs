namespace _04.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int controlNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nextNumber = numbers[j];
                    if (number + nextNumber == controlNumber)
                    {
                        Console.WriteLine($"{number} {nextNumber}");
                        break;
                    }
                }
            }
        }
    }
}