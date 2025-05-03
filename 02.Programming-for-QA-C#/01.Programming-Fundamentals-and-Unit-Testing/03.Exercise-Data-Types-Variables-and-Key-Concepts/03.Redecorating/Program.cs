namespace _03.Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nylonPrice = 1.50;
            double paintPrice = 14.50;
            double thinnerPrice = 5.00;
            double bags = 0.40;

            double nylon = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            double thinner = double.Parse(Console.ReadLine());
            double hoursOfWork = double.Parse(Console.ReadLine());

            nylon = nylon + 2; // nylon += 2;
            paint = paint * 1.1;

            double nylonCost = nylon * 1.50;
            double paintCost = paint * 14.50;
            double thinnerCost = thinner * 5.00;

            double totalMaterialCosts = nylonCost + paintCost + thinnerCost + bags;

            double workPrice = totalMaterialCosts * 0.3;
            double totalWorkCost = hoursOfWork * workPrice;

            double totalCost = totalMaterialCosts + totalWorkCost;
            Console.WriteLine(totalCost);
        }
    }
}