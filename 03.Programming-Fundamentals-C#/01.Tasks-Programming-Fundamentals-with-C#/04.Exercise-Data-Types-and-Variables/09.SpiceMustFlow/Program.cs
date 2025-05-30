using System.Numerics;

decimal dobivs = decimal.Parse(Console.ReadLine());

decimal days = 0;
decimal allDobiv = 0;

while (true)
{
    if (dobivs >= 100)
    {
        days++;
        decimal n = dobivs - 26;
        allDobiv += n;
        dobivs -= 10;
    }
    else if (dobivs < 100)
    {
        allDobiv -= 26;
        dobivs -= 10;
        if (allDobiv <= 0)
        {
            allDobiv = 0;

        }
        dobivs -= 10;
        break;
    }

    if (dobivs < 0)
    {
        break;
    }
}


Console.WriteLine(days);
Console.WriteLine(allDobiv);