
// Input
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

// Calculations + Output

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine(firstNumber);
    }
}

if (secondNumber > firstNumber)
{
    if (secondNumber > thirdNumber)
    {
        Console.WriteLine(secondNumber);
    }
}

if (thirdNumber > firstNumber)
{
    if (thirdNumber > secondNumber)
    {
        Console.WriteLine(thirdNumber);
    }
}