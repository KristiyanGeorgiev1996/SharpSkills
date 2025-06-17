while (true)
{
    string text = Console.ReadLine();

    if (text == "end")
    {
        break;
    }
    else
    {
        string reversedText = "";

        for (int i = text.Length - 1; i >= 0; i--)
        {
            reversedText += text[i];
        }
        Console.WriteLine($"{text} = {reversedText}");
    }
}