string input = Console.ReadLine();

////char middleCharacter = input[input.Length / 2];

MiddleCharacter(input);

void MiddleCharacter(string input)
{
    if (input.Length % 2 == 0)
    {
        char middleCharacter2 = input[(input.Length / 2) - 1];
        char middleCharakter = input[input.Length / 2];
        Console.WriteLine($"{middleCharacter2}{middleCharakter}");
    }
    else if (input.Length % 2 == 1)
    {
        char middleCharacter = input[input.Length / 2];
        Console.WriteLine(middleCharacter);
    }
}