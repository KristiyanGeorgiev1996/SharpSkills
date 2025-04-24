namespace _01.SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new ArgumentNullException("Invalid number.");
                }

                double sqrt = Math.Sqrt(number);
                Console.WriteLine(sqrt);
            }
            catch (Exception ex) // тук влизаме само ако е хвърлена грешка
            {
                Console.WriteLine(ex.Message);
            }
            finally // този код се изпълнява независимо дали е възникнала грешка или не
            {
                Console.WriteLine("Goodbye.");
            }

        }
    }
}