string text = Console.ReadLine();
////string result = text.Remove(text.Length - 1);

int sum = 0;

////(text[i] == "A" || text[i] == "a" || text[i] == "e" || text[i] == "E" || text[i] == "i" || text[i] == "I" || text[i] == "o" || text[i] == "O" || text[i] == "u" || text[i] == "U")

while (text.Length != 0)
{
    char lastCharacter = text[text.Length - 1];
    if (lastCharacter == 'A' || lastCharacter == 'a' || lastCharacter == 'e' || lastCharacter == 'E' || lastCharacter == 'i' || lastCharacter == 'I' || lastCharacter == 'o' || lastCharacter == 'O' || lastCharacter == 'u' || lastCharacter == 'U')
    {
        sum++;
    }
    text = text.Remove(text.Length - 1);
}
Console.WriteLine(sum);