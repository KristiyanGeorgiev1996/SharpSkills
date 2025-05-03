
List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string input = Console.ReadLine();

while (input != "end")
{
    string[] comandParts = input.Split();
    string commandName = comandParts[0];

    if (commandName == "Delete")
    {
        int elementForDelete = int.Parse(comandParts[1]);
        numbers.RemoveAll(e => e == elementForDelete);
    }
    else if (commandName == "Insert")
    {
        int elementToInsert = int.Parse(comandParts[1]);
        int positionToInsert = int.Parse(comandParts[2]);

        numbers.Insert(positionToInsert, elementToInsert);
    }

    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));