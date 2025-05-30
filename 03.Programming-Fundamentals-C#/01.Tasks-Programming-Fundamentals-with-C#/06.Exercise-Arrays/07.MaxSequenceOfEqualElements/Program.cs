string[] symbol = Console.ReadLine().Split();

int bestCount = 0;
string bestSymbol = "";

for (int i = symbol.Length - 1; i >= 0; i--)
{
    int count = 1;
    for (int j = i - 1; j >= 0; j--)
    {
        if (symbol[i] == symbol[j])
        {
            count++;
            if (bestCount <= count)
            {
                bestCount = count;
                bestSymbol = symbol[i];
            }

        }
        else
        {
            break;
        }
    }


}
for (int i = 0; i < bestCount; i++)
{
    Console.Write($"{bestSymbol} ");
}
