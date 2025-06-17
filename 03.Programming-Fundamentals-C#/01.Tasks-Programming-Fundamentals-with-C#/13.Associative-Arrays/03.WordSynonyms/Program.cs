Dictionary<string, List<string>> wordSynonims = new Dictionary<string, List<string>>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string word = Console.ReadLine();
    string synonim = Console.ReadLine();

    if (!wordSynonims.ContainsKey(word))
    {
        wordSynonims.Add(word, new List<string>());
    }
    wordSynonims[word].Add(synonim);
}

foreach (var wordSynonim in wordSynonims)
{
    Console.WriteLine($"{wordSynonim.Key} - {String.Join(", ", wordSynonim.Value)}");
}