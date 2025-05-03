namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add test for following scenario:
            // 10 10 10
            // 10 10 10
            // expected result --> 10x9 || 10x3
            int[] firstArray = ReadIntArray();
            int[] secondArray = ReadIntArray();

            foreach (int firstArrayNumber in firstArray)
            {
                foreach (int secondArrayNumber in secondArray)
                {
                    if (firstArrayNumber == secondArrayNumber)
                    {
                        Console.Write($"{firstArrayNumber} ");
                        break;
                    }
                }
            }
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