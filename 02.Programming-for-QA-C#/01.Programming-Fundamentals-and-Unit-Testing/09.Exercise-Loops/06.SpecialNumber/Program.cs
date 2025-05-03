namespace _06.SpecialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isSpecial = true;
            int copyOfNumber = number;

            while (number > 0)
            {
                int lastDigit = number % 10;
                if (copyOfNumber % lastDigit != 0)
                {
                    isSpecial = false;
                    Console.WriteLine($"{copyOfNumber} is not special");
                    break;
                }

                number /= 10;
            }

            if (isSpecial)
            {
                Console.WriteLine($"{copyOfNumber} is special");
            }
        }
    }
}