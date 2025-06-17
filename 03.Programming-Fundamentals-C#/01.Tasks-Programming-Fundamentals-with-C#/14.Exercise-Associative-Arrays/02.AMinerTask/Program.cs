using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

string resource = Console.ReadLine();

Dictionary<string, int> resources = new Dictionary<string, int>();

while (true)
{
    if (resource == "stop")
    {
        break;
    }
    else
    {
        int sum = int.Parse(Console.ReadLine());
        if (!resources.ContainsKey(resource))
        {
            resources.Add(resource, sum);
        }
        else
        {
            resources[resource] += sum;
        }

    }
    resource = Console.ReadLine();
}

foreach (var item in resources)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}

//if (!chars.ContainsKey(letter))
//{
//    chars.Add(letter, 1);
//}
//else
//{
//    chars[letter]++;
//}