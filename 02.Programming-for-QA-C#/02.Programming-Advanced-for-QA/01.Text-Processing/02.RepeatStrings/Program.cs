using System.Text;

string[] wordsArray = Console.ReadLine().Split(" ");

StringBuilder output = new StringBuilder();

foreach (string word in wordsArray)
{
    for (int i = 0; i < word.Length; i++)
    {
        output.Append(word);
    }
}

Console.WriteLine(output.ToString());