int end = int.Parse(Console.ReadLine());
int currentNum = 1;

for (int i = 1; i <= end; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(currentNum + " ");
        currentNum++;

        if (currentNum > end)
        {
            break;
        }
    }

    Console.WriteLine();

    if (currentNum > end)
    {
        break;
    }

}