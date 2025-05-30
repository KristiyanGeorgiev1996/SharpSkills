int numbers = int.Parse(Console.ReadLine());
decimal sum = 0;

for (int i = 0; i < numbers; i++)
{
    decimal number = decimal.Parse(Console.ReadLine());
    sum += number;
}
Console.WriteLine(sum);
