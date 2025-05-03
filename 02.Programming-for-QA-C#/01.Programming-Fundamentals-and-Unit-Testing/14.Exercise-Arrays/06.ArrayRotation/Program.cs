namespace _06.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rotations = int.Parse(Console.ReadLine());

            rotations = rotations % numbers.Length;
            while (rotations > 0)
            {
                int firstNumber = numbers[0];
                int[] tempArray = new int[numbers.Length];

                for (int i = 1; i < numbers.Length; i++)
                {
                    int currentNumber = numbers[i];
                    tempArray[i - 1] = currentNumber;
                }

                tempArray[numbers.Length - 1] = firstNumber;
                numbers = tempArray;
                rotations--;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}