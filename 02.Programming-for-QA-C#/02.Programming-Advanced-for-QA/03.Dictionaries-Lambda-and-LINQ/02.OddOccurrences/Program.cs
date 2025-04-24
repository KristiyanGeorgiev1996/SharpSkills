
List<string> words = Console.ReadLine()
                            .Split(' ')
                            .Select(w => w.ToLower()) // прави всички букви малки във всяка дума
                            .ToList();

Dictionary<string, int> numbersAndCount = new Dictionary<string, int>();

for (int i = 0; i < words.Count; i++)
{
    string key = words[i];

    if (numbersAndCount.ContainsKey(key)) // ако съдържа този ключ, увеличи value с 1
    {
        numbersAndCount[key]++;
    }
    else // ако не съдържа ключа, добави го
    {
        numbersAndCount.Add(key, 1);
    }
}

foreach (var item in numbersAndCount)
{
    if (item.Value % 2 != 0) // печатаме само ключове с нечетна стойност срещу него
    {
        Console.Write(item.Key + " ");
    }
}