string text = Console.ReadLine();

for (int i = 0; i < text.Length; i++)
{
    int asciiNumber = (int)text[i];
    asciiNumber += 3;
    char character = (char)asciiNumber;
    Console.Write(character);
}