string text = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

Rtring(text, count);

void Rtring(string text, int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{text}");
    }
}