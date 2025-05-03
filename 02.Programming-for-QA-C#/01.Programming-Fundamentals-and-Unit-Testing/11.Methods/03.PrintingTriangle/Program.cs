
int n = int.Parse(Console.ReadLine());

PrintTriange(n);

static void PrintTriange(int n)
{
    // прав цикъл за първата част на триъгълника
    for (int row = 1; row < n; row++)
    {
        PrintLine(1, row);
    }

    // обърнат цикъл за втората част на триъгълника
    for (int row = n; row >= 1; row--)
    {
        PrintLine(1, row);
    }
}

// метод който принтира само един ред от триъгълника
static void PrintLine(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}