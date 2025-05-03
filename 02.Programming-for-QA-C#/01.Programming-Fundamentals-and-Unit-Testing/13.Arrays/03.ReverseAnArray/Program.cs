
int n = int.Parse(Console.ReadLine());

// създаваме масив с n на брой елемента
int[] numbers = new int[n];

// пулним масива със стойности от всеки ред от конзолата
for (int i = 0; i < n; i++)
{
    int currNum = int.Parse(Console.ReadLine());

    numbers[i] = currNum;
}

// дълъг вариант за обръщане на масив
int[] reversedArray = new int[n];

for (int i = numbers.Length - 1; i >= 0; i--)
{
    reversedArray[numbers.Length - i - 1] = numbers[i];
}

Console.WriteLine(string.Join(" ", reversedArray));

// по-кратък вариант на горните 4 реда
//numbers = numbers.Reverse().ToArray();
//Console.WriteLine(string.Join(" ", numbers));