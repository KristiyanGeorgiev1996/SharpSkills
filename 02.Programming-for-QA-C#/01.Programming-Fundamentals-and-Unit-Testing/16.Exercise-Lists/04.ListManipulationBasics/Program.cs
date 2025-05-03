
List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    string[] commandParts = command.Split(" ");
    string commandName = commandParts[0];

    switch (commandName)
    {
        case "Add":
            int numberToAdd = int.Parse(commandParts[1]);
            numbers.Add(numberToAdd);
            break;
        case "Remove":
            int numberToRemove = int.Parse(commandParts[1]);
            numbers.Remove(numberToRemove);
            break;
        case "RemoveAt":
            int positionForRemove = int.Parse(commandParts[1]);
            numbers.RemoveAt(positionForRemove);
            break;
        case "Insert":
            int numberToInsert = int.Parse(commandParts[1]);
            int positionToInsert = int.Parse(commandParts[2]);
            numbers.Insert(positionToInsert, numberToInsert);
            break;
    }


    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));