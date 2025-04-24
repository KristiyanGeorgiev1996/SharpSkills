
string input = Console.ReadLine();

while (input != "end")
{
    // нова променлива за обърнатия вход
    string reversedInput = "";

    // обикаляме текста от входа отзад напред
    for (int i = input.Length - 1; i >= 0; i--)
    {
        // добавяме всеки символ отзад напред
        reversedInput += input[i];
    }

    // печатаме изхода
    Console.WriteLine($"{input} = {reversedInput}");

    // прочитаме нов вход от конзолата
    input = Console.ReadLine();
}