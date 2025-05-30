int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{

    if (numbers.Length == 3)
    {
        int firstNum = numbers[0];
        int secondNum = numbers[1];
        int thirdNum = numbers[2];
        numbers[0] = secondNum;
        numbers[1] = thirdNum;
        numbers[2] = firstNum;
    }
    else if (numbers.Length == 4)
    {
        int firstNum = numbers[0];
        int secondNum = numbers[1];
        int thirdNum = numbers[2];
        int fourthNum = numbers[3];
        numbers[0] = secondNum;
        numbers[1] = thirdNum;
        numbers[2] = fourthNum;
        numbers[3] = firstNum;
    }
    else if (numbers.Length == 5)
    {
        int firstNum = numbers[0];
        int secondNum = numbers[1];
        int thirdNum = numbers[2];
        int fourthNum = numbers[3];
        int fifthNum = numbers[4];
        numbers[0] = secondNum;
        numbers[1] = thirdNum;
        numbers[2] = fourthNum;
        numbers[3] = fifthNum;
        numbers[4] = firstNum;
    }
    else if (numbers.Length == 6)
    {
        int firstNum = numbers[0];
        int secondNum = numbers[1];
        int thirdNum = numbers[2];
        int fourthNum = numbers[3];
        int fifthNum = numbers[4];
        int sixthNum = numbers[5];
        numbers[0] = secondNum;
        numbers[1] = thirdNum;
        numbers[2] = fourthNum;
        numbers[3] = fifthNum;
        numbers[4] = sixthNum;
        numbers[5] = firstNum;
    }
    else if (numbers.Length == 7)
    {
        int firstNum = numbers[0];
        int secondNum = numbers[1];
        int thirdNum = numbers[2];
        int fourthNum = numbers[3];
        int fifthNum = numbers[4];
        int sixthNum = numbers[5];
        int sevenNum = numbers[6];
        numbers[0] = secondNum;
        numbers[1] = thirdNum;
        numbers[2] = fourthNum;
        numbers[3] = fifthNum;
        numbers[4] = sixthNum;
        numbers[5] = sevenNum;
        numbers[6] = firstNum;
    }
    else if (numbers.Length == 2)
    {
        int firstNum = numbers[0];
        int secondNum = numbers[1];
        numbers[0] = secondNum;
        numbers[1] = firstNum;
    }
    else if (numbers.Length == 8)
    {
        int firstNum = numbers[0];
        int secondNum = numbers[1];
        int thirdNum = numbers[2];
        int fourthNum = numbers[3];
        int fifthNum = numbers[4];
        int sixthNum = numbers[5];
        int sevenNum = numbers[6];
        int eightNum = numbers[7];
        numbers[0] = secondNum;
        numbers[1] = thirdNum;
        numbers[2] = fourthNum;
        numbers[3] = fifthNum;
        numbers[4] = sixthNum;
        numbers[5] = sevenNum;
        numbers[6] = eightNum;
        numbers[7] = firstNum;
    }
}
for (int i = 0; i < numbers.Length; i++)
{
    if (i == numbers.Length - 1)
    {
        Console.Write(numbers[i]);
    }
    else
    {
        Console.Write(numbers[i] + " ");
    }
}