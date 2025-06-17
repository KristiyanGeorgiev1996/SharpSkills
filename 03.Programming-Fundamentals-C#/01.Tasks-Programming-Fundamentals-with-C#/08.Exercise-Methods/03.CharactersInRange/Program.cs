using System.Text;

char one = char.Parse(Console.ReadLine());
char two = char.Parse(Console.ReadLine());

if (one < two)
{
    for (int i = one + 1; i < two; i++)
    {
        Console.Write($"{(char)(i)} ");
    }
}
else if (one > two)
{
    for (int i = two + 1; i < one; i++)
    {
        Console.Write($"{(char)(i)} ");
    }
}
