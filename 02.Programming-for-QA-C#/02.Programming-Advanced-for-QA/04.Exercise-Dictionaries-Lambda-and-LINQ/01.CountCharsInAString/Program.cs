// четем вход от конзолата
string input = Console.ReadLine();

// подготвяме си речник в който ще пазим символите и тяхната бройка
Dictionary<char, int> characters = new Dictionary<char, int>();

// с for цикъл обикаляме целия текст символ по символ
for (int i = 0; i < input.Length; i++)
{
    // вадим си текущия символ
    char currentChar = input[i];

    // ако текущия символ е празен интервал, го пропускаме
    if (currentChar == ' ')
    {
        continue;
    }

    // проверяваме дали не съществира този ключ в речника
    if (!characters.ContainsKey(currentChar))
    {
        characters.Add(currentChar, 1);
    }
    else // ако съществура, само променяме неговата стойност
    {
        characters[currentChar]++;
    }
}

// печатаме всички KeyValuePair на конзолата
foreach (KeyValuePair<char, int> kvp in characters)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}