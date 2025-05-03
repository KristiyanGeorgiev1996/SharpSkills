namespace P05_BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int[] bombArgs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bombNumber = bombArgs[0];
            int bombPower = bombArgs[1];
            if (bombPower < 0)
            {
                // BombPower is negative => Left Index and Right Index are swapped
                // Workaround: Make BombNumber positive
                bombPower *= -1;
            }

            while (numbers.Contains(bombNumber))
            {
                int indexOfBomb = numbers.IndexOf(bombNumber);
                int leftIndex = indexOfBomb - bombPower;
                if (leftIndex < 0)
                {
                    // Left index is outside of the list (located to the left)
                    // Then start taking from the start of the list which is 0 index
                    leftIndex = 0;
                }

                int rightIndex = indexOfBomb + bombPower;
                if (rightIndex >= numbers.Count)
                {
                    // Right index is outside of the list (located to the right)
                    // Then take until the end of the list which is index Count - 1
                    rightIndex = numbers.Count - 1;
                }

                int elementsToRemove = rightIndex - leftIndex + 1;
                for (int i = 0; i < elementsToRemove; i++)
                {
                    // The elements to the right are shifted left because of the removed element
                    // => We can repeat RemoveAt(LeftIndex) elements count times
                    numbers.RemoveAt(leftIndex);
                }
            }

            long numbersSum = SumNumbers(numbers);
            Console.WriteLine(numbersSum);
        }

        static long SumNumbers(List<int> numbers)
        {
            long sum = 0L;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}