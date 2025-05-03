
// Input

double depositAmount = double.Parse(Console.ReadLine());
int countOfMonts = int.Parse(Console.ReadLine());
double interestPercentPerYear = double.Parse(Console.ReadLine());

// Calculate

double yearIncome = depositAmount * interestPercentPerYear / 100;
double monthIncome = yearIncome / 12;
double finalAmount = depositAmount + (countOfMonts * monthIncome);

// Output

Console.WriteLine($"{finalAmount:F2}");