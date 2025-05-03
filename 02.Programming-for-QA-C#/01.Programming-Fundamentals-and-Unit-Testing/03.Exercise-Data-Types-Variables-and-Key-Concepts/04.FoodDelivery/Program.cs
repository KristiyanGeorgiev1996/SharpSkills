namespace _04.FoodDelivery
{
    internal class Program
    {
        // F5 --> looking for brakepoint
        // F10 --> step over
        // F11 --> step into
        static void Main(string[] args)
        {
            double chickenMenuPrice = 10.35;
            double fishMenuPrice = 12.40;
            double vegetarianMenuPrice = 8.15;
            double deliveryPrice = 2.50;

            double chickenMenuOrderQuantity = double.Parse(Console.ReadLine());
            double fishMenuOrderQuantity = double.Parse(Console.ReadLine());
            double vegetarianMenuOrderQuantity = double.Parse(Console.ReadLine());

            double chickenOrderCost = chickenMenuOrderQuantity * chickenMenuPrice;
            double fishOrderCost = fishMenuOrderQuantity * fishMenuPrice;
            double vegeterianOrderCost = vegetarianMenuOrderQuantity * vegetarianMenuPrice;

            double totalMenuOrderCost = chickenOrderCost + fishOrderCost + vegeterianOrderCost;

            double desertOrderPercentage = 0.2;
            double totalDesertOrderCost = totalMenuOrderCost * desertOrderPercentage;

            double totalOrderCost = totalMenuOrderCost + totalDesertOrderCost + deliveryPrice;
            Console.WriteLine(totalOrderCost);
        }
    }
}