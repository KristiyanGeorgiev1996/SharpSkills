int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int sumEven = 0;
int sumOdd = 0;
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    int currentNumber = numbers[i];
    if (currentNumber % 2 == 0)
    {
        sumEven += currentNumber;
    }
    else if (currentNumber % 2 == 1)
    {
        sumOdd += currentNumber;
    }
}

result = sumEven - sumOdd;
Console.WriteLine(result);