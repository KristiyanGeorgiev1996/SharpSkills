
// Input

double tomatoPricePerKg = double.Parse(Console.ReadLine());
double tomatoQuantity = double.Parse(Console.ReadLine());
double cucumberPricePerKg = double.Parse(Console.ReadLine());
double cucumberQuantity = double.Parse(Console.ReadLine());

// Calculations

double tomatoPrice = tomatoPricePerKg * tomatoQuantity;
double cucumberPrice = cucumberPricePerKg * cucumberQuantity;
double finalPrice = tomatoPrice + cucumberPrice;

// Output

Console.WriteLine($"{finalPrice:F2}");