namespace _06.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            PrintResult(product, quantity);
        }

        static void PrintResult(string product, int quantity)
        {
            double result2 = GetTotalOrderPrice(product, quantity);
            double result = GetTotalOrderPrice2(product, quantity);
            Console.WriteLine($"{result:F2}");
        }

        static double GetTotalOrderPrice(string product, int quantity)
        {
            double price = 0;
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
            }

            return price * quantity;
        }

        static double GetTotalOrderPrice2(string product, int quantity) =>
            product switch
            {
                "coffee" => quantity * 1.50,
                "water" => quantity * 1.00,
                "coke" => quantity * 1.40,
                "snacks" => quantity * 2.00
            };
    }
}