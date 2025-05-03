// Input
int points = int.Parse(Console.ReadLine());

// Calculations
if (points >= 0 && points <= 3)
{
    points = points + 5;
    //points += 5; по-кратък запис на горния ред
}
else if (points >= 4 && points <= 6)
{
    points = points + 15;
}
else if (points >= 7 && points <= 9)
{
    points = points + 20;
}

// Output
Console.WriteLine(points);