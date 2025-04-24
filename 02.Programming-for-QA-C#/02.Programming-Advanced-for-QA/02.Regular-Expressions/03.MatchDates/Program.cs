
using System.Text.RegularExpressions;

string pattern = @"(?<Day>\d{2})(?<separator>[.\-/])(?<Month>[A-Z][a-z]{2})\<separator>(?<Year>\d{4})";

string input = Console.ReadLine();

Regex regex = new Regex(pattern);

// .IsMatch връща стойност true, ако има съвпадения в текста (Matches)
if (regex.IsMatch(input))
{
    MatchCollection dates = Regex.Matches(input, pattern);

    foreach (Match match in dates)
    {
        string day = match.Groups["Day"].Value;
        string month = match.Groups["Month"].Value;
        string year = match.Groups["Year"].Value;

        Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
    }
}