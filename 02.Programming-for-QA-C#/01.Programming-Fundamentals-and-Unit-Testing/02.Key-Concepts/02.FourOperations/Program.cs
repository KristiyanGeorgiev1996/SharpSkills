
// Input

double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());

// Calculations

double additionResult = firstNumber + secondNumber;
double subtractResult = firstNumber - secondNumber;
double multiplicationResult = firstNumber * secondNumber;
double divideResult = firstNumber / secondNumber;

// Output

Console.WriteLine($"{firstNumber:F2} + {secondNumber:F2} = {additionResult:F2}");
Console.WriteLine($"{firstNumber:F2} - {secondNumber:F2} = {subtractResult:F2}");
Console.WriteLine($"{firstNumber:F2} * {secondNumber:F2} = {multiplicationResult:F2}");
Console.WriteLine($"{firstNumber:F2} / {secondNumber:F2} = {divideResult:F2}");