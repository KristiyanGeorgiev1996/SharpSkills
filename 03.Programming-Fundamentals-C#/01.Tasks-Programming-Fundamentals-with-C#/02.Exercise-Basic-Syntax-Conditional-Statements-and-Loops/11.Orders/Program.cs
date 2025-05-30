double poruhki = double.Parse(Console.ReadLine());
double allSum = 0;
for (int i = 0; i < poruhki; i++)
{
    double priceforCapsule = double.Parse(Console.ReadLine());
    double days = double.Parse(Console.ReadLine());
    double capsuleCount = double.Parse(Console.ReadLine());

    double totalSum = (days * capsuleCount) * priceforCapsule;
    allSum += totalSum;
    Console.WriteLine($"The price for the coffee is: ${totalSum:F2}");
}

Console.WriteLine($"Total: ${allSum:F2}");