namespace _02.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int firstNumberFactorial = Factorial(firstNumber);
            int secondNumberFactorial = Factorial(secondNumber);

            int result = firstNumberFactorial / secondNumberFactorial;
            Console.WriteLine(result);
        }

        static int Factorial(int n) // n = 5
        {
            int result = 1;
            if (n == 0 || n == 1)
            {
                return result;
            }

            for (int i = n; i >= 2; i--)
            {
                result *= i;
            }

            return result;
        }

        //static int CalculateFactorial(int n) // n = 5
        //{
        //    if (n == 0 || n == 1)
        //    {
        //        return 1;
        //    }

        //    var test = CalculateFactorial(n - 1);

        //    return n * test; // n * CalculateFactorial(n - 1)
        //}
    }
}