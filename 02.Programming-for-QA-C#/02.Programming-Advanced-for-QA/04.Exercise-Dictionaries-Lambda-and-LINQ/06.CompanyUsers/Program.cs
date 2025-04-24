// Key - companyName
// Value - list with eployeeId's
Dictionary<string, List<string>> companies = new();

string input = Console.ReadLine();

while (input != "End")
{
    string[] tokens = input.Split(" -> ");
    string companyName = tokens[0];
    string employeeId = tokens[1];

    // проверявам дали компанията я има в речника
    if (companies.ContainsKey(companyName))
    {
        // проверявам дали компанията има вече такъв служител
        if (!companies[companyName].Contains(employeeId))
        {
            companies[companyName].Add(employeeId);
        }
    }
    else
    {
        // добавям компанията в речника и инициализирам нов лист
        companies.Add(companyName, new List<string>());

        // добавям първия служител в компанията
        companies[companyName].Add(employeeId);
    }

    input = Console.ReadLine();
}

foreach (var kvp in companies)
{
    Console.WriteLine(kvp.Key);

    // функционален код, който може да замести вложения foreach
    //Console.WriteLine(string.Join(Environment.NewLine, kvp.Value.Select(e => "-- " + e)));

    foreach (var employeeId in kvp.Value)
    {
        Console.WriteLine($"-- {employeeId}");
    }
}