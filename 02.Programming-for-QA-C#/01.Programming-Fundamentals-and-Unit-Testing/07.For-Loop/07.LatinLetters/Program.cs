// Input

char startLetter = char.Parse(Console.ReadLine());
char endLetter = char.Parse(Console.ReadLine());

// Output

for (char letter = startLetter; letter <= endLetter; letter++)
{
    Console.Write(letter + " ");
}