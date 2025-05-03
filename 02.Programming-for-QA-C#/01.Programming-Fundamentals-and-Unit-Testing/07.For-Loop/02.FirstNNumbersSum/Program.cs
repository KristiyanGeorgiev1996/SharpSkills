// Input

int n = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= n; i++)
{
    sum = sum + i;

    if (i < n)
        Console.Write(i + "+");
    else if (i == n)
        Console.Write(i);
}

Console.WriteLine($"={sum}");