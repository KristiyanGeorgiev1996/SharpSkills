// създаваме масив с дължина 7, защото изборяваме 7 елемента след това
string[] days = new string[]
{
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};

// четем число от конзолата
int number = int.Parse(Console.ReadLine());

// проверяваме дали числото отговатя на пореден ден от седмицата
if (number >= 1 && number <= 7)
{
    // изваждаме единица, защото индексите започват от нула (0)
    Console.WriteLine(days[number - 1]);
}
else
{
    Console.WriteLine("Invalid day!");
}