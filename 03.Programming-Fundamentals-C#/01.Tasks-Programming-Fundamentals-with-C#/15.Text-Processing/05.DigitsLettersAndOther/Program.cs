string someString = Console.ReadLine();

string digits = "";
string letters = "";
string cymbols = "";

for (int i = 0; i < someString.Length; i++)
{
    if (char.IsLetter(someString[i]))
    {
        letters += someString[i];
    }
}
for (int i = 0; i < someString.Length; i++)
{
    if (char.IsDigit(someString[i]))
    {
        digits += someString[i];
    }
}
for (int i = 0; i < someString.Length; i++)
{
    if (!char.IsDigit(someString[i]) && !char.IsLetter(someString[i]))
    {
        cymbols += someString[i];
    }
}

Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(cymbols);