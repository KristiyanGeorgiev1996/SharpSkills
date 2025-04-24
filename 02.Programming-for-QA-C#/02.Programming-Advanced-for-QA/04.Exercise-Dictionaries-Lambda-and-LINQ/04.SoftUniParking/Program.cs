
Dictionary<string, string> parking = new();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] cmdArg = Console.ReadLine().Split(' ');

    string command = cmdArg[0];
    string username = cmdArg[1];

    if (command == "register")
    {
        string licensePlateNumber = cmdArg[2];

        if (parking.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: already registered with plate number {parking[username]}");
        }

        if (!parking.ContainsKey(username))
        {
            parking.Add(username, licensePlateNumber);
            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
        }
    }
    else if (command == "unregister")
    {
        if (!parking.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: user {username} not found");
        }
        else
        {
            parking.Remove(username);
            Console.WriteLine($"{username} unregistered successfully");
        }
    }
}

foreach (var kvp in parking)
{
    Console.WriteLine($"{kvp.Key} => {kvp.Value}");
}