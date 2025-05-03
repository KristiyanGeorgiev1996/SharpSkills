// Input
double n1 = double.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());
double n3 = double.Parse(Console.ReadLine());

// Calculations + Output
if (n1 < n2 && n2 < n3)
{
    Console.WriteLine("Ascending");
}
else if (n1 > n2 && n2 > n3)
{
    Console.WriteLine("Descending");
}
else
{
    Console.WriteLine("Not sorted");
}