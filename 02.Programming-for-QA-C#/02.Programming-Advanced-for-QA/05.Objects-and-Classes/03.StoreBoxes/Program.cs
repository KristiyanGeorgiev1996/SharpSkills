using System.Text;

namespace _03.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                //"19861519 Dove 15 2.50"
                string[] tokens = input.Split(' ');
                string serialNmber = tokens[0];
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                double itemPrice = double.Parse(tokens[3]);

                Item currentItem = new Item(itemName, itemPrice);
                Box currentBox = new Box(serialNmber, currentItem, itemQuantity);

                boxes.Add(currentBox);

                input = Console.ReadLine();
            }

            foreach (var box in boxes.OrderByDescending(b => b.Price))
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine(box.SerialNumber);
                sb.AppendLine($"-- {box.Item.Name} – ${box.Item.Price:F2}: {box.ItemQuantity}");
                sb.AppendLine($"-- ${box.Price:F2}");

                Console.WriteLine(sb.ToString().TrimEnd());
            }
        }
    }

    public class Item
    {
        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }
    }

    public class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
        }

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public double Price => Item.Price * ItemQuantity;

    }

}