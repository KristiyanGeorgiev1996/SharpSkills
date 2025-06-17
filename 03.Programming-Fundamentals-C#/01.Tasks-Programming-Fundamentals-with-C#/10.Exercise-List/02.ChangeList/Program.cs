List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

while (true)
{
    string command = Console.ReadLine();
    string[] commandArray = command.Split();
    if (command == "end")
    {
        break;
    }

    if (commandArray[0] == "Delete")
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            int numberToDelete = int.Parse(commandArray[1]);
            numbers.Remove(numberToDelete);
        }
    }
    else if (commandArray[0] == "Insert")
    {
        int numbertoInsert = int.Parse(commandArray[1]);
        int indexToInsert = int.Parse(commandArray[2]);
        numbers.Insert(indexToInsert, numbertoInsert);
    }
}

Console.WriteLine(string.Join(" ", numbers));