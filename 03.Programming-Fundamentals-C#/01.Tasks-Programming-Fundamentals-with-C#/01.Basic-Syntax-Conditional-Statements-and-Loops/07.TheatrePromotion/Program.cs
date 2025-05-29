string day = Console.ReadLine();
int ages = int.Parse(Console.ReadLine());

if (day == "Weekday")
{
    if (ages >= 0 && ages <= 18)
    {
        Console.WriteLine("12$");
    }
    else if (ages >= 19 && ages <= 64)
    {
        Console.WriteLine("18$");
    }
    else if (ages >= 65 && ages <= 122)
    {
        Console.WriteLine("12$");
    }
    else
    {
        Console.WriteLine("Error!");
    }
}
else if (day == "Weekend")
{
    if (ages >= 0 && ages <= 18)
    {
        Console.WriteLine("15$");
    }
    else if (ages >= 19 && ages <= 64)
    {
        Console.WriteLine("20$");
    }
    else if (ages >= 65 && ages <= 122)
    {
        Console.WriteLine("15$");
    }
    else
    {
        Console.WriteLine("Error!");
    }
}
else if (day == "Holiday")
{
    if (ages >= 0 && ages <= 18)
    {
        Console.WriteLine("5$");
    }
    else if (ages >= 19 && ages <= 64)
    {
        Console.WriteLine("12$");
    }
    else if (ages >= 65 && ages <= 122)
    {
        Console.WriteLine("10$");
    }
    else
    {
        Console.WriteLine("Error!");
    }
}
else
{
    Console.WriteLine("Error!");
}
