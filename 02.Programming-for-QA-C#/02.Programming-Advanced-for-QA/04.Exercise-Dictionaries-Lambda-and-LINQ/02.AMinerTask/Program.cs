
Dictionary<string, int> mineResources = new();

string resourceName = Console.ReadLine();

while (resourceName != "stop")
{
    int quantity = int.Parse(Console.ReadLine());

    // ако ключа не съществува, го добавяме с value нула
    if (!mineResources.ContainsKey(resourceName))
    {
        mineResources.Add(resourceName, 0);
    }

    // всеки път добавяме количеството към съществуващ ключ
    mineResources[resourceName] += quantity;

    resourceName = Console.ReadLine();
}

foreach (var kvp in mineResources)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}