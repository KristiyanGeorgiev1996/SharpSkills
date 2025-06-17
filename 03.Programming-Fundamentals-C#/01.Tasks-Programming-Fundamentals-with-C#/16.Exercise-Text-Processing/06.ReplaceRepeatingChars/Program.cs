string text = Console.ReadLine();
string newText = "";

for (int i = 0; i < text.Length; i++)
{
    if (i == 0)
    {
        char c = text[i];
        newText += c;
    }
    else if (text[i] != text[i - 1])
    {
        char b = text[i];
        newText += b;
    }
}

Console.WriteLine(newText);