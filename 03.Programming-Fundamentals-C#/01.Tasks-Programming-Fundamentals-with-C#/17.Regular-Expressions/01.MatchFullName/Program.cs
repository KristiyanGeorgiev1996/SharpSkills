using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

        RegexOptions options = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input, pattern, options))
        {
            Console.Write(m.Value + " ");
        }
    }
}