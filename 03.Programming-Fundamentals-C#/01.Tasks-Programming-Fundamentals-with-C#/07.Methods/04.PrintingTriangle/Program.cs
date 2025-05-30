using System.Drawing;

int n = int.Parse(Console.ReadLine());
Rectangle(n);
void Rectangle(int n)
{
    for (int i = 0; i < n; i++)
    {
        Rectangle2(i + 1);
    }
    for (int i = 1; i < n; i++)
    {
        Rectangle2(n - i);
    }
}
void Rectangle2(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{i + 1} ");
    }
    Console.WriteLine();
}