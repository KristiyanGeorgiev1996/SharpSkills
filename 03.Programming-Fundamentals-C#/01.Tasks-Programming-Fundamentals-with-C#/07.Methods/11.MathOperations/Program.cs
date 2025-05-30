int firstNumber = int.Parse(Console.ReadLine());
string calculation = Console.ReadLine();
int secNumber = int.Parse(Console.ReadLine());

int sum = 0;
MathOperations(firstNumber, secNumber);

void MathOperations(int firstNumber, int secNumber)
{
    if (calculation == "*")
    {
        sum = firstNumber * secNumber;
    }
    else if (calculation == "+")
    {
        sum = firstNumber + secNumber;
    }
    else if (calculation == "/")
    {
        sum = firstNumber / secNumber;
    }
    else if (calculation == "-")
    {
        sum = firstNumber - secNumber;
    }
}
Console.WriteLine(sum);