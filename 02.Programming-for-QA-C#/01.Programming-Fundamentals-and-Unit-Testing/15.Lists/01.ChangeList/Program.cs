
List<int> numbers = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToList();

string input = Console.ReadLine();

while (input != "end")
{
    string[] cmdArg = input.Split(' ');

    string command = cmdArg[0];

    if (command == "Delete")
    {
        int elementToremove = int.Parse(cmdArg[1]);

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == elementToremove)
            {
                numbers.RemoveAt(i);
                i--;
            }
        }
    }
    else if (command == "Insert")
    {
        int element = int.Parse(cmdArg[1]);
        int index = int.Parse(cmdArg[2]);

        numbers.Insert(index, element);
    }

    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));
List<int> numbers = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToList();

string input = Console.ReadLine();

while (input != "end")
{
    string[] cmdArg = input.Split(' ');

    string command = cmdArg[0];

    if (command == "Delete")
    {
        int elementToremove = int.Parse(cmdArg[1]);

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == elementToremove)
            {
                numbers.RemoveAt(i);
                i--;
            }
        }
    }
    else if (command == "Insert")
    {
        int element = int.Parse(cmdArg[1]);
        int index = int.Parse(cmdArg[2]);

        numbers.Insert(index, element);
    }

    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));