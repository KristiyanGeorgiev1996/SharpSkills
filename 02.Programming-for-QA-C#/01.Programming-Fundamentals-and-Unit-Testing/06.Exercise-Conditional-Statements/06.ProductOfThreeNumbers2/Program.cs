namespace _06.ProductOfThreeNumbers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int countOfNegativeNumbers = 0; // 1 || 3
            if (a < 0)
            {
                countOfNegativeNumbers++;
            }

            if (b < 0)
            {
                countOfNegativeNumbers++;
            }

            if (c < 0)
            {
                countOfNegativeNumbers++;
            }

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("zero");
            }
            else if (countOfNegativeNumbers == 1 || countOfNegativeNumbers == 3)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
}