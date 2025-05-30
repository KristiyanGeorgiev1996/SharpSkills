int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

double allSum = 0;

for (int i = number1; i <= number2; i++)
{
    Console.Write($"{i} ");
    allSum += i;
}
Console.WriteLine();
Console.WriteLine($"Sum: {allSum}");
