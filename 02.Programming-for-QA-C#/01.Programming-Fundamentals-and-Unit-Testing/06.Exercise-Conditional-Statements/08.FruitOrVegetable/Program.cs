namespace _08.FruitOrVegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productType = Console.ReadLine();
            switch (productType)
            {
                case "banana" or "apple" or "kiwi" or "cherry" or "lemon":
                    Console.WriteLine("fruit");
                    break;
                case "cucumber" or "pepper" or "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}