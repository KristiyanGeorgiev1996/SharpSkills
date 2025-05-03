// Input
string typeOfMovie = Console.ReadLine();
int countOfRows = int.Parse(Console.ReadLine());
int countOfSeatsPerRow = int.Parse(Console.ReadLine());

// Calculations
int allSeatsInTheater = countOfRows * countOfSeatsPerRow;
double priceForOneTicket = 0;

switch (typeOfMovie)
{
    case "Premiere": priceForOneTicket = 12; break;
    case "Normal": priceForOneTicket = 7.50; break;
    case "Discount": priceForOneTicket = 5; break;
}

double finalPrice = allSeatsInTheater * priceForOneTicket;

// Output
Console.WriteLine($"{finalPrice:F2}");