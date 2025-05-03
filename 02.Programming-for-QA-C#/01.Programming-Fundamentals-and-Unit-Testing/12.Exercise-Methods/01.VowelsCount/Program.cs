namespace _01.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            int result = GetVowelsCount(inputText);

            string inputText2 = Console.ReadLine();
            result = GetVowelsCount(inputText);
            Console.WriteLine(result);
        }

        static int GetVowelsCount(string text)
        {
            int result = 0;
            foreach (char letter in text)
            {
                if (letter == 'a'
                    || letter == 'o'
                    || letter == 'u'
                    || letter == 'e'
                    || letter == 'i'
                    || letter == 'A'
                    || letter == 'O'
                    || letter == 'U'
                    || letter == 'E'
                    || letter == 'I'
                    )
                {
                    result++;
                }
            }

            return result;
        }
    }
}