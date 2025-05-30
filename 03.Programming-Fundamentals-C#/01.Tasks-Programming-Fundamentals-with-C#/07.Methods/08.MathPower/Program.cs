double n = double.Parse(Console.ReadLine());
double x = double.Parse(Console.ReadLine());
double sum = 0;
double totalSum = 0;
double numbersOfX = x;

MathPower(n, x);

void MathPower(double n, double x)
{
    if (n != 0 && x != 0)
    {
        double Poq = Math.Pow(n, x);
        Console.WriteLine(Poq);
    }
    else
    {
        Console.WriteLine(0);
    }
}
