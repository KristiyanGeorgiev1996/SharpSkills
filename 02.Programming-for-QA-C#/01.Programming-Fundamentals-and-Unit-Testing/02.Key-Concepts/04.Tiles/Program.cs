// Input
double roomWidth = double.Parse(Console.ReadLine());
double roomHeight = double.Parse(Console.ReadLine());

double tileWidth = double.Parse(Console.ReadLine());
double tileHeight = double.Parse(Console.ReadLine());

// Calculations
double roomArea = roomWidth * roomHeight;

double tileArea = tileWidth * tileHeight;

double tiles = roomArea / tileArea * 1.1;

// Output
Console.WriteLine(Math.Round(tiles));