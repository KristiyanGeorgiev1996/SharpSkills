namespace _03.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = ReadIntArray();

            while (numbers.Length > 1)
            {
                int[] tempArray = new int[numbers.Length - 1];
                for (int i = 0; i < tempArray.Length; i++)
                {
                    int currentNumber = numbers[i];
                    int nextNumber = numbers[i + 1];

                    tempArray[i] = currentNumber + nextNumber;
                }

                numbers = tempArray;
            }

            Console.WriteLine(numbers[0]);
        }

        private static int[] ReadIntArray()
        {
            return Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();
        }
    }
}