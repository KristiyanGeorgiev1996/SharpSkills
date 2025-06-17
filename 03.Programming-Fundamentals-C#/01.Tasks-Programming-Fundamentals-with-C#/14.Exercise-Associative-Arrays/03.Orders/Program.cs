using System.Data;
using System.Resources;
using System.Security.Authentication.ExtendedProtection;

Dictionary<string, (double Price, double Quantity)> price = new();


while (true)
{
    string command = Console.ReadLine();
    if (command == "buy")
    {
        break;
    }
    else
    {
        string[] splittedCommand = command.Split();
        string productName = splittedCommand[0];
        double cena = double.Parse(splittedCommand[1]);
        double kolichestvo = double.Parse(splittedCommand[2]);
        if (!price.ContainsKey(splittedCommand[0]))
        {
            price.Add(productName, (cena, kolichestvo));
        }
        else
        {
            var currentData = price[productName];
            double newQuantity = currentData.Quantity + kolichestvo;
            double newPrice = cena;
            price[productName] = (newPrice, newQuantity);

        }
    }
}

foreach (var item in price)
{
    double totalValue = item.Value.Price * item.Value.Quantity;
    Console.WriteLine($"{item.Key} -> {totalValue:F2}");
}