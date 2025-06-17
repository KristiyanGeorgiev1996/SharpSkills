int n = int.Parse(Console.ReadLine());

List<string> names = new List<string>();

while (n > 0)
{
    List<string> nameGoing = Console.ReadLine().Split().ToList();
    if (nameGoing[nameGoing.Count - 2] == "is")
    {
        int count = 0;
        for (int i = 0; i < names.Count; i++)
        {
            if (nameGoing[0] == names[i])
            {
                count++;
                break;
            }
        }
        if (count == 0)
        {
            names.Add(nameGoing[0]);
        }
        else
        {
            Console.WriteLine($"{nameGoing[0]} is already in the list!");
        }
        //// names.Add(nameGoing[0]);
    }
    else if (nameGoing[nameGoing.Count - 2] == "not")
    {
        int count = 0;
        for (int i = 0; i < names.Count; i++)
        {
            if (nameGoing[0] == names[i])
            {
                count++;
                break;
            }

        }
        if (count != 0)
        {
            names.Remove(nameGoing[0]);
        }
        else
        {
            Console.WriteLine($"{nameGoing[0]} is not in the list!");
        }
    }

    n--;
}

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}