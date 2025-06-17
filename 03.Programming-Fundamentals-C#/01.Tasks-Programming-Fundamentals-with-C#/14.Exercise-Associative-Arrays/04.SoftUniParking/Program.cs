Dictionary<string, string> parkingCard = new Dictionary<string, string>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    List<string> members = Console.ReadLine().Split(" ").ToList();


    if (members[0] == "register")
    {
        string second = members[1];
        string third = members[2];
        if (!parkingCard.ContainsKey(second))
        {
            parkingCard.Add(second, third);
            Console.WriteLine($"{second} registered {third} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {third}");
        }
    }
    else if (members[0] == "unregister")
    {
        string second = members[1];
        if (!parkingCard.ContainsKey(second))
        {
            Console.WriteLine($"ERROR: user {members[1]} not found");
        }
        else
        {
            parkingCard.Remove(second);
            Console.WriteLine($"{members[1]} unregistered successfully");
        }
    }
}

foreach (var item in parkingCard)
{
    Console.WriteLine($"{item.Key} => {item.Value}");
}