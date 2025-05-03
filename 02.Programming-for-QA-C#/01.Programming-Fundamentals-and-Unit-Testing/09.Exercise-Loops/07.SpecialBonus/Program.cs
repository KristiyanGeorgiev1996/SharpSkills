namespace _07.SpecialBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stopNumber = int.Parse(Console.ReadLine());

            int previousNumber = 0;
            while (true)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber == stopNumber)
                {
                    break;
                }

                previousNumber = currentNumber;
            }

            Console.WriteLine(previousNumber * 1.2);
        }
    }
}