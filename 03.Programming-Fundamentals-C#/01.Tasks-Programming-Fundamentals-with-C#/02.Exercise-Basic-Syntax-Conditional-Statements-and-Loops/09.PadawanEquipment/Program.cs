double money = double.Parse(Console.ReadLine());
int students = int.Parse(Console.ReadLine());
double swords = double.Parse(Console.ReadLine());
double belt = double.Parse(Console.ReadLine());
double robe = double.Parse(Console.ReadLine());

double realSwords = students * 1.1;
double realPriceSwords = Math.Ceiling(realSwords);

double freeBelts = students / 6;
double realNumOfBelts = students - freeBelts;
double realBelts = Math.Floor(realNumOfBelts);

double allPriceOfSwords = swords * realPriceSwords;
double allPriceOfBelts = realBelts * robe;
double allPriceOfRobe = students * belt;


double allSum = allPriceOfBelts + allPriceOfRobe + allPriceOfSwords;

if (allSum <= money)
{
    Console.WriteLine($"The money is enough - it would cost {allSum:F2}lv.");
}
else
{
    double needed = allSum - money;
    Console.WriteLine($" John will need {needed:F2}lv more.");
}