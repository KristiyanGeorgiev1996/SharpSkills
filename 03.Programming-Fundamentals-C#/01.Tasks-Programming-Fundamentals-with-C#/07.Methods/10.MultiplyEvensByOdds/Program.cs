int input = Math.Abs(int.Parse(Console.ReadLine()));
int odd = 0;
int even = 0;
while (input > 0)
{
    int lastDigit = input % 10;
    if (lastDigit % 2 == 0)
    {
        even += lastDigit;
    }

    else
    {
        odd += lastDigit;
    }

    input /= 10;
}

int result = even * odd;
Console.WriteLine(result);