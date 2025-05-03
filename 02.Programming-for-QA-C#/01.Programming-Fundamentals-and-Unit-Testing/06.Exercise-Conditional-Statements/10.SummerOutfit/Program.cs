namespace _10.SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine()); // 10 - 42
            string dayPart = Console.ReadLine(); // "Morning", "Afternoon", "Evening"

            string clothing = "Shirt";
            string shoes = "Moccasins";

            if ((dayPart == "Morning" && temperature >= 25)
                || (dayPart == "Afternoon" && (18 < temperature && temperature <= 24)))
            {
                clothing = "T-Shirt";
                shoes = "Sandals";
            }
            else if (dayPart == "Morning"
                && (10 <= temperature && temperature <= 18))
            {
                clothing = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if (dayPart == "Afternoon"
                && temperature >= 25)
            {
                clothing = "Swim Suit";
                shoes = "Barefoot";
            }

            Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
        }
    }
}