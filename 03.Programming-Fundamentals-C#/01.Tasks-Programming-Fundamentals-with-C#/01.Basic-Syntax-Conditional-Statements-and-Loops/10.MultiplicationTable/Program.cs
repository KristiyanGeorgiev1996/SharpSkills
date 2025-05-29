int n = int.Parse(Console.ReadLine());

int times = 0;

for (int i = 1; i <= 10; i++)
{
    times += 1;
    double product = n * times;
    Console.WriteLine($"{n} X {times} = {product}");
}