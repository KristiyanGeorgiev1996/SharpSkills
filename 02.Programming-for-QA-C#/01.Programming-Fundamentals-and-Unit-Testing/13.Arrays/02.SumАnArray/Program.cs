
int[] numbersArray = Console.ReadLine()        // четем стринг от конзолата
                            .Split(" ")        // разделяме го на масив от стгрингове
                            .Select(int.Parse) // всеки елемент го партсваме към int
                            .ToArray();        // обръщаме финалната колекция в масив

int sum = 0;

for (int i = 0; i < numbersArray.Length; i++)
{
    int currentNumber = numbersArray[i];

    sum += currentNumber;
}

Console.WriteLine(sum);