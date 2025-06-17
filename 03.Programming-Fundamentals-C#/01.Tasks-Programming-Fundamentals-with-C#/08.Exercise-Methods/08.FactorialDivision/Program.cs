using System.Numerics;

decimal n = decimal.Parse(Console.ReadLine());
decimal x = decimal.Parse(Console.ReadLine());

decimal fact = n;
decimal fact2 = x;

for (decimal i = n; i > 1; i--)
{
    fact *= (i - 1);
}

for (decimal i = x; i > 1; i--)
{
    fact2 *= (i - 1);
}

decimal divide = fact / fact2;

Console.WriteLine($"{divide:F2}");
