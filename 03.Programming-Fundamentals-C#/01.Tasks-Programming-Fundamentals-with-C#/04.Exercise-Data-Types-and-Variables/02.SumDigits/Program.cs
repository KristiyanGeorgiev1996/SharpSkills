int number = int.Parse(Console.ReadLine());

double N = 0;
double sumOfNumber = 0;

sumOfNumber = 0;
while (number != 0)
{
    sumOfNumber += number % 10;
    number /= 10;

}
Console.WriteLine(sumOfNumber);