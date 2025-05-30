int number = int.Parse(Console.ReadLine());

int nuberCopy = number;
int factSum = 0;


while (nuberCopy > 0)
{
    int digit = nuberCopy % 10;
    nuberCopy /= 10;

    int factorial = 1;
    for (int i = 1; i <= digit; i++)
    {
        factorial *= i;
    }

    factSum += factorial;

}
string isStronngNumber = number == factSum ? "yes" : "no";
Console.WriteLine(isStronngNumber);


