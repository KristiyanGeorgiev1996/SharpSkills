string product = Console.ReadLine();
int price = int.Parse(Console.ReadLine());

double totalSum = 0;

TotalPriceOfProducts(product, price);

void TotalPriceOfProducts(string product, double price)
{
    if (product == "coffee")
    {
        totalSum = price * 1.50;
        Console.WriteLine($"{totalSum:F2}");
    }
    else if (product == "water")
    {
        totalSum = price * 1.00;
        Console.WriteLine($"{totalSum:F2}");
    }
    else if (product == "coke")
    {
        totalSum = price * 1.40;
        Console.WriteLine($"{totalSum:F2}");
    }
    else if (product == "snacks")
    {
        totalSum = price * 2.00;
        Console.WriteLine($"{totalSum:F2}");
    }
}