// Input

string ticketType = Console.ReadLine();

// Output

// Декларирам променлива price
double price = 0;

if (ticketType == "student")
{
    // инициализирам променливата (придавам стойност)
    price = 1;
}
else if (ticketType == "regular")
{
    // инициализирам променливата (придавам стойност)
    price = 1.6;
}
else
{
    Console.WriteLine("Invalid ticket type!");
}

if (price > 0)
    Console.WriteLine($"${price:F2}");