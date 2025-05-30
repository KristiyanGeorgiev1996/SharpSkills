using System.Text;

int n = int.Parse(Console.ReadLine());

int sum = 0;

while (n != 0)
{
    char letter = char.Parse(Console.ReadLine());
    int intOfLetter = (int)(letter);
    sum += intOfLetter;
    n--;
}
Console.WriteLine($"The sum equals: {sum}");