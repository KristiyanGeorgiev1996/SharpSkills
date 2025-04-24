
List<string> bannedWords = Console.ReadLine()
                                  .Split(", ")
                                  .ToList();

string text = Console.ReadLine();

foreach (string wordToReplace in bannedWords)
{
    string asterixWord = new string('*', wordToReplace.Length);

    text = text.Replace(wordToReplace, asterixWord);
}

Console.WriteLine(text);