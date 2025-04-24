namespace _03.SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integerNumbers = new List<int>();

            //"2147483649 2 3.4 5 invalid 24 -4"

            string[] inputArray = Console.ReadLine().Split(' ');

            // [ "2147483649", "2", "3.4", "5", "invalid", "24", "-4" ]

            foreach (var element in inputArray)
            {
                try
                {
                    int currentNumber = int.Parse(element);
                    integerNumbers.Add(currentNumber);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{element}' is in wrong format!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{element}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{element}' processed - current sum: {integerNumbers.Sum()}");
                }
            }

            Console.WriteLine($"The total sum of all integers is: {integerNumbers.Sum()}");
        }
    }
}