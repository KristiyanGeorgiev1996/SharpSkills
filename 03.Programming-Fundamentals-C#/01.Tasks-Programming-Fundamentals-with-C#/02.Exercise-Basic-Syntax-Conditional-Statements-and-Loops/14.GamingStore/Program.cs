double currentBalance = double.Parse(Console.ReadLine());
double currentBalance1 = currentBalance;

while (currentBalance1 != 0)
{
    string game = Console.ReadLine();
    if (game == "Game Time")
    {
        break;
    }
    if (game == "OutFall 4" || game == "RoverWatch Origins Edition")
    {
        if (currentBalance1 < 39.99)
        {
            Console.WriteLine("Too Expensive");
        }
        else
        {
            Console.WriteLine($"Bought {game}");
            currentBalance1 -= 39.99;
        }
        if (currentBalance1 == 0)
        {
            Console.WriteLine("Out of money!");
            break;
        }
    }
    else if (game == "CS: OG")
    {
        if (currentBalance1 < 15.99)
        {
            Console.WriteLine("Too Expensive");
        }
        else
        {
            Console.WriteLine($"Bought {game}");
            currentBalance1 -= 15.99;
        }
        if (currentBalance1 == 0)
        {
            Console.WriteLine("Out of money!");
            break;
        }
    }
    else if (game == "Zplinter Zell")
    {
        if (currentBalance1 < 19.99)
        {
            Console.WriteLine("Too Expensive");
        }
        else
        {
            Console.WriteLine($"Bought {game}");
            currentBalance1 -= 19.99;
        }
        if (currentBalance1 == 0)
        {
            Console.WriteLine("Out of money!");
            break;
        }
    }
    else if (game == "Honored 2")
    {
        if (currentBalance1 < 59.99)
        {
            Console.WriteLine("Too Expensive");
        }
        else
        {
            Console.WriteLine($"Bought {game}");
            currentBalance1 -= 59.99;
        }
        if (currentBalance1 == 0)
        {
            Console.WriteLine("Out of money!");
            break;
        }
    }
    else if (game == "RoverWatch")
    {
        if (currentBalance1 < 29.99)
        {
            Console.WriteLine("Too Expensive");
        }
        else
        {
            Console.WriteLine($"Bought {game}");
            currentBalance1 -= 29.99;
        }
        if (currentBalance1 == 0)
        {
            Console.WriteLine("Out of money!");
            break;
        }
    }
    else
    {
        Console.WriteLine("Not Found");
        game = Console.ReadLine();
    }

}

double spent = currentBalance - currentBalance1;
Console.WriteLine($"Total spent: ${spent:F2}. Remaining: ${currentBalance1:F2}");
