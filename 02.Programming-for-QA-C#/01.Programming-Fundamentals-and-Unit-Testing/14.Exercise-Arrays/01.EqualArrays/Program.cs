namespace _01.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = ReadIntArray();
            int[] secondArray = ReadIntArray();

            for (int i = 0; i < firstArray.Length; i++)
            {
                int firstArrayCurrentElement = firstArray[i];
                int secondArrayCurrentElement = secondArray[i];

                if (firstArrayCurrentElement != secondArrayCurrentElement)
                {
                    Console.WriteLine("Arrays are not identical.");
                    return;
                }
            }

            Console.WriteLine("Arrays are identical.");
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