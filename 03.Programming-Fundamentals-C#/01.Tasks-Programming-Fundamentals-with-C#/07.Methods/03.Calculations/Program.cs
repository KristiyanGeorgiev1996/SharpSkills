string mathOperacion = Console.ReadLine();
int firstNumber = int.Parse(Console.ReadLine());
int secNumber = int.Parse(Console.ReadLine());

int sum = 0;

MathOperation(mathOperacion);

void MathOperation(string mathOperation)
{
    if (mathOperation == "add")
    {
        sum = firstNumber + secNumber;
        Console.WriteLine(sum);
    }
    else if (mathOperation == "divide")
    {
        sum = firstNumber / secNumber;
        Console.WriteLine(sum);
    }
    else if (mathOperation == "multiply")
    {
        sum = firstNumber * secNumber;
        Console.WriteLine(sum);
    }
    else if (mathOperation == "subtract")
    {
        sum = firstNumber - secNumber;
        Console.WriteLine(sum);
    }
}