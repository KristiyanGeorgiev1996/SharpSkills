using System.Diagnostics.Tracing;

int peoples = int.Parse(Console.ReadLine());
string typeOfGroup = Console.ReadLine();
string dayOfWeek = Console.ReadLine();

double price = 0;
double discount = 0;
double totalPrice = 0;

if (typeOfGroup == "Students" && dayOfWeek == "Friday")
{
    price = peoples * 8.45;
    if (peoples >= 30)
    {
        discount = price * 0.85;
        totalPrice = discount;
    }
    else
    {
        totalPrice = price;
    }
}
else if (typeOfGroup == "Students" && dayOfWeek == "Saturday")
{
    price = peoples * 9.80;
    if (peoples >= 30)
    {
        discount = price * 0.85;
        totalPrice = discount;
    }
    else
    {
        totalPrice = price;
    }
}
else if (typeOfGroup == "Students" && dayOfWeek == "Sunday")
{
    price = peoples * 10.46;
    if (peoples >= 30)
    {
        discount = price * 0.85;
        totalPrice = discount;
    }
    else
    {
        totalPrice = price;
    }
}
else if (typeOfGroup == "Business" && dayOfWeek == "Friday")
{
    price = peoples * 10.90;
    if (peoples >= 100)
    {
        double people = peoples - 10;
        double peoplesss = people * 10.9;
        totalPrice = peoplesss;
    }
    else
    {
        totalPrice = price;
    }
}
else if (typeOfGroup == "Business" && dayOfWeek == "Saturday")
{
    price = peoples * 15.60;
    if (peoples >= 100)
    {
        double people = peoples - 10;
        double peoplesss = people * 15.60;
        totalPrice = peoplesss;
    }
    else
    {
        totalPrice = price;
    }
}
else if (typeOfGroup == "Business" && dayOfWeek == "Sunday")
{
    price = peoples * 16;
    if (peoples >= 100)
    {
        double people = peoples - 10;
        double peoplesss = people * 16;
        totalPrice = peoplesss;
    }
    else
    {
        totalPrice = price;
    }
}
else if (typeOfGroup == "Regular" && dayOfWeek == "Friday")
{
    price = peoples * 15;
    if (peoples >= 10 && peoples <= 20)
    {
        discount = price * 0.95;
        totalPrice = discount;
    }
    else
    {
        totalPrice = price;
    }
}
else if (typeOfGroup == "Regular" && dayOfWeek == "Saturday")
{
    price = peoples * 20;
    if (peoples >= 10 && peoples <= 20)
    {
        discount = price * 0.95;
        totalPrice = discount;
    }
    else
    {
        totalPrice = price;
    }
}
else if (typeOfGroup == "Regular" && dayOfWeek == "Sunday")
{
    price = peoples * 22.50;
    if (peoples >= 10 && peoples <= 20)
    {
        discount = price * 0.95;
        totalPrice = discount;
    }
    else
    {
        totalPrice = price;
    }
}

Console.WriteLine($"Total price: {totalPrice:F2}");