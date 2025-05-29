int odd = int.Parse(Console.ReadLine());
var sum = 0;
for (int i = 1; i <= odd + odd; i += 2)
{
    sum += i;
    Console.WriteLine(i);
}

Console.WriteLine($"Sum: {sum}");