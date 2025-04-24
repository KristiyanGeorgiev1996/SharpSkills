
int n = int.Parse(Console.ReadLine());

Dictionary<string, List<string>> words = new();

for (int i = 0; i < n; i++)
{
    string currerntWord = Console.ReadLine();
    string synonym = Console.ReadLine();

    if (!words.ContainsKey(currerntWord))
    {
        words.Add(currerntWord, new List<string>());
    }

    words[currerntWord].Add(synonym);
}

foreach (var kvp in words)
{
    Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
}