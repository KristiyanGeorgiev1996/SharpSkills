
// Input
string product = Console.ReadLine();
string typeOfDay = Console.ReadLine();

// Calculations
double price = 0;

if (typeOfDay == "Weekday")
{
    if (product == "Banana")
        price = 2.50;
    else if (product == "Apple")
        price = 1.30;
    else if (product == "Kiwi")
        price = 2.2;
}
else if (typeOfDay == "Weekend")
{
    if (product == "Banana")
        price = 2.70;
    else if (product == "Apple")
        price = 1.60;
    else if (product == "Kiwi")
        price = 3;
}

// Output
Console.WriteLine($"{price:F2}");