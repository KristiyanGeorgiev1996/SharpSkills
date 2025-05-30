int n = int.Parse(Console.ReadLine());
int allLiters = 0;

for (int i = 1; i <= n; i++)
{
    int liters = int.Parse(Console.ReadLine());
    if (liters > 255)
    {
        Console.WriteLine("Insufficient capacity!");
    }
    else if (liters + allLiters <= 255)
    {
        allLiters += liters;
    }
    else if (liters + allLiters > 255)
    {
        Console.WriteLine("Insufficient capacity!");
    }
}
Console.WriteLine(allLiters);