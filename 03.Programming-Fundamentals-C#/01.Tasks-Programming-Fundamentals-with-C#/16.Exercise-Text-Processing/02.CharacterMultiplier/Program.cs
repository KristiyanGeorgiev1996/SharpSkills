string[] randomStrings = Console.ReadLine().Split();

int totalSum = 0;

if (randomStrings[0].Length == randomStrings[1].Length)
{
    for (int i = 0; i < randomStrings[0].Length; i++)
    {
        int asciiNumber = (int)randomStrings[0][i];
        int asciiNumber2 = (int)randomStrings[1][i];
        int sum = asciiNumber * asciiNumber2;
        totalSum += sum;
    }
}
else if (randomStrings[0].Length < randomStrings[1].Length)
{
    for (int i = 0; i < randomStrings[0].Length; i++)
    {
        int asciiNumber = (int)randomStrings[0][i];
        int asciiNumber2 = (int)randomStrings[1][i];
        int sum = asciiNumber * asciiNumber2;
        totalSum += sum;
    }
    for (int i = randomStrings[0].Length; i < randomStrings[1].Length; i++)
    {
        int asciiNumber = (int)randomStrings[1][i];
        totalSum += asciiNumber;
    }
}
else if (randomStrings[0].Length > randomStrings[1].Length)
{
    for (int i = 0; i < randomStrings[1].Length; i++)
    {
        int asciiNumber = (int)randomStrings[0][i];
        int asciiNumber2 = (int)randomStrings[1][i];
        int sum = asciiNumber * asciiNumber2;
        totalSum += sum;
    }
    for (int i = randomStrings[1].Length; i < randomStrings[0].Length; i++)
    {
        int asciiNumber = (int)randomStrings[0][i];
        totalSum += asciiNumber;
    }
}

Console.WriteLine(totalSum);

/////char character = 'A';
/////int asciiValue = (int)character;
/////Console.WriteLine(asciiValue); // Output: 65