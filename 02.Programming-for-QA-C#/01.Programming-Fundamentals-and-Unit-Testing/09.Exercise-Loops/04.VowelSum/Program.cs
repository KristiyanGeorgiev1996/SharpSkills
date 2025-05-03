namespace _04.VowelSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int result = 0;
            for (int i = 0; i < n; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                if (currentChar == 'a')
                {
                    result += 1;
                }
                else if (currentChar == 'e')
                {
                    result += 2;
                }
                else if (currentChar == 'i')
                {
                    result += 3;
                }
                else if (currentChar == 'o')
                {
                    result += 4;
                }
                else if (currentChar == 'u')
                {
                    result += 5;
                }
            }

            Console.WriteLine(result);
        }
    }
}