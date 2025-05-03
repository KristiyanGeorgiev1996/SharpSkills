
string type = Console.ReadLine();
string firstValue = Console.ReadLine();
string secondValue = Console.ReadLine();

CompareTwoValues(type, firstValue, secondValue);



static void CompareTwoValues(string type, string firstValue, string secondValue)
{
    if (type == "int")
    {
        int x = int.Parse(firstValue);
        int y = int.Parse(secondValue);

        int biggest = CompareTwoIntegers(x, y);

        Console.WriteLine(biggest);
    }
    else if (type == "char")
    {
        char firstChar = char.Parse(firstValue);
        char secondChar = char.Parse(secondValue);

        char biggest = CompareTwoChars(firstChar, secondChar);

        Console.WriteLine(biggest);
    }
    else if (type == "string")
    {
        string biggest = CompareTwoStrings(firstValue, secondValue);

        Console.WriteLine(biggest);
    }
};

static int CompareTwoIntegers(int x, int y)
{
    if (x > y)
    {
        return x;
    }

    return y;
}

static char CompareTwoChars(char a, char b)
{
    if (a > b)
    {
        return a;
    }

    return b;
}

static string CompareTwoStrings(string a, string b)
{
    int result = a.CompareTo(b);

    if (result > 0)
    {
        return a;
    }

    return b;
}