using System.ComponentModel.Design;

string text = Console.ReadLine();

while (text != "END")
{
    if (text == "END")
    {
        break;
    }
    if (text.Length == 1)
    {
        Console.WriteLine("true");
        text = Console.ReadLine();
    }
    else if (text.Length == 2)
    {
        Console.WriteLine("false");
        text = Console.ReadLine();
    }
    else if (text.Length == 3)
    {
        if (text[text.Length - 1] == text[text.Length - 3])
        {
            Console.WriteLine("true");
            text = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("false");
            text = Console.ReadLine();
        }
    }
    else if (text.Length == 4)
    {
        if (text[text.Length - 1] == text[text.Length - 4] && text[text.Length - 2] == text[text.Length - 3])
        {
            Console.WriteLine("true");
            text = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("false");
            text = Console.ReadLine();
        }
    }
    else if (text.Length == 5)
    {
        if (text[text.Length - 1] == text[text.Length - 5] && text[text.Length - 2] == text[text.Length - 4])
        {
            Console.WriteLine("true");
            text = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("false");
            text = Console.ReadLine();
        }
    }
    else if (text.Length == 6)
    {
        if (text[text.Length - 1] == text[text.Length - 6] && text[text.Length - 2] == text[text.Length - 5] && text[text.Length - 3] == text[text.Length - 4])
        {
            Console.WriteLine("true");
            text = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("false");
            text = Console.ReadLine();
        }
    }
}