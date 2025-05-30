using System.ComponentModel.Design;

int number = int.Parse(Console.ReadLine());

////2 3 6 7 10

int chislo = 0;

if (number % 10 == 0)
{
    chislo = 10;
    Console.WriteLine($"The number is divisible by {chislo}");
}
else if (number % 7 == 0)
{
    chislo = 7;
    Console.WriteLine($"The number is divisible by {chislo}");
}
else if (number % 6 == 0)
{
    chislo = 6;
    Console.WriteLine($"The number is divisible by {chislo}");
}
else if (number % 3 == 0)
{
    chislo = 3;
    Console.WriteLine($"The number is divisible by {chislo}");
}
else if (number % 2 == 0)
{
    chislo = 2;
    Console.WriteLine($"The number is divisible by {chislo}");
}
if (chislo == 0)
{
    Console.WriteLine("Not divisible");
}
