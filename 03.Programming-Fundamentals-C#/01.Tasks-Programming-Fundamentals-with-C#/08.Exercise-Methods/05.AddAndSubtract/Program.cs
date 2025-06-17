int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

SumOfThreeDigits(a, b, c);

void SumOfThreeDigits(int a, int b, int c)
{
    int totalSum = (a + b) - c;
    Console.WriteLine(totalSum);
}