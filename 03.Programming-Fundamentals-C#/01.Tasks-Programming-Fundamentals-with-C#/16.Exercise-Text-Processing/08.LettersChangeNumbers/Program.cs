using System;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine().Trim();
        string[] strings = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        decimal totalSum = 0;

        foreach (string str in strings)
        {
            char firstChar = str[0];
            char lastChar = str[str.Length - 1];
            string numberStr = "";
            int numberStartIndex = -1;

            // Find the number in the string
            for (int i = 1; i < str.Length - 1; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    numberStr += str[i];
                    if (numberStartIndex == -1)
                    {
                        numberStartIndex = i;
                    }
                }
                else
                {
                    break;
                }
            }

            int number = int.Parse(numberStr);

            // Process the first character before the number
            if (char.IsUpper(firstChar))
            {
                decimal divisor = firstChar - 'A' + 1;
                totalSum += (decimal)number / divisor;
            }
            else if (char.IsLower(firstChar))
            {
                decimal multiplier = firstChar - 'a' + 1;
                totalSum += (decimal)number * multiplier;
            }

            // Process the last character after the number
            if (char.IsUpper(lastChar))
            {
                totalSum -= (decimal)(lastChar - 'A' + 1);
            }
            else if (char.IsLower(lastChar))
            {
                totalSum += (decimal)(lastChar - 'a' + 1);
            }
        }

        // Print the total sum rounded to two decimal places
        Console.WriteLine($"{totalSum:F2}");
    }
}
