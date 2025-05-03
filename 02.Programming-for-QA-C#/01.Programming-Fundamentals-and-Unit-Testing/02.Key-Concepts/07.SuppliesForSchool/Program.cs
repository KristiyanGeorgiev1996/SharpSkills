
// Input

int countOfPensPackages = int.Parse(Console.ReadLine());
int countOfMarkersPackages = int.Parse(Console.ReadLine());
int litersOfBoardCleaner = int.Parse(Console.ReadLine());
int discountPercentage = int.Parse(Console.ReadLine());

// Calculations

double priceForPens = countOfPensPackages * 5.80;
double priceForMarkers = countOfMarkersPackages * 7.20;
double priceForBoardCleaner = litersOfBoardCleaner * 1.20;

// цената за всички материали 
double priceForMaterials = priceForPens + priceForMarkers + priceForBoardCleaner;

// отстъпка
double discount = priceForMaterials * discountPercentage / 100;

// крайна цена
double finalPrice = priceForMaterials - discount;

// Output
Console.WriteLine(finalPrice);