int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());

double product = 0;
int times = secondNum;

if (secondNum <= 10)
{
    for (int i = secondNum; i <= 10; i++)
    {
        product = firstNum * times;
        Console.WriteLine($"{firstNum} X {times} = {product}");
        times += 1;
    }
}
else
{
    product = firstNum * secondNum;
    Console.WriteLine($"{firstNum} X {secondNum} = {product}");
}