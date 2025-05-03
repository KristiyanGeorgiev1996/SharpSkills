int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for (int num = start; num <= end; num++)
{
    // брояч: едно число дали се дели на повече от две числа без остатък
    int primeCounter = 0;

    for (int i = 1; i <= num; i++)
    {
        // проверяваме дали числото се дели на друго число без остатък
        if (num % i == 0)
        {
            primeCounter++;
        }
    }

    // ако бороята е останал на 2, значи числото е просто и го изписваме на конзолата
    if (primeCounter == 2)
    {
        Console.Write($"{num} ");
    }
}