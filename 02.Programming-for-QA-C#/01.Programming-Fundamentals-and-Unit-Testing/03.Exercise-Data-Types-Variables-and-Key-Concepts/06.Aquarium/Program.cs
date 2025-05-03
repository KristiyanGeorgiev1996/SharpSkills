namespace _06.Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            string b = Console.ReadLine();
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double decorationPercetange = double.Parse(Console.ReadLine());

            double aquariumVolumeInCm = length * width * height;
            double aquariumVolumeInLiters = aquariumVolumeInCm * 0.001;

            //double decorationPercentageVolume = aquariumVolumeInLiters * (decorationPercetange / 100);
            //double result = aquariumVolumeInLiters - decorationPercentageVolume;

            double result = aquariumVolumeInLiters * (decorationPercetange / 1000);
            Console.WriteLine($"{result:F2}");
        }
    }
}