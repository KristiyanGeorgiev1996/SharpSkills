namespace _03.MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            string result = GetMultiplicationSign(a, b, c);
            Console.WriteLine(result);
        }

        static string GetMultiplicationSign(int a, int b, int c)
        {
            string result = "";
            if (IsAnyNumberZero(a, b, c))
            {
                result = "zero";
            }
            else if (GetNegativeNumbersCount(a, b, c) % 2 == 0)
            {
                result = "positive";
            }
            else
            {
                result = "negative";
            }

            return result;
        }

        static int GetNegativeNumbersCount(int a, int b, int c)
        {
            int negativeNumbers = 0;
            if (a < 0)
            {
                negativeNumbers++;
            }

            if (b < 0)
            {
                negativeNumbers++;
            }

            if (c < 0)
            {
                negativeNumbers++;
            }

            return negativeNumbers;
        }

        static bool IsAnyNumberZero(int a, int b, int c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                return true;
            }

            return false;
        }
    }
}