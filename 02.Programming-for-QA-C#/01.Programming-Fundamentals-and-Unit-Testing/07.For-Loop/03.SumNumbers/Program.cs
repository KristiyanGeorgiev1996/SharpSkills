// Input

int n = int.Parse(Console.ReadLine());

// Calculations

double sum = 0;

for (int i = 1; i <= n; i++)
{
    double currentNumber = double.Parse(Console.ReadLine());

    sum += currentNumber;
}

// Ouput 

Console.WriteLine(sum);