
using System.Text.RegularExpressions;

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

string input = Console.ReadLine();

MatchCollection regexMatches = Regex.Matches(input, pattern);

// по-подробен вариант за принтиране на намерените съвпадения
foreach (Match item in regexMatches)
{
    Console.Write(item + " ");
}

// по-кратък вариант за принтиране на намерените съвпадения
//Console.WriteLine(string.Join(" ", regexMatches);