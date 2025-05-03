namespace _09.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine()); // 15
            int secondTime = int.Parse(Console.ReadLine()); // 20
            int thirdTime = int.Parse(Console.ReadLine()); // 30

            int totalTimeInSeconds = firstTime + secondTime + thirdTime; // 65

            int minutes = totalTimeInSeconds / 60;
            int seconds = totalTimeInSeconds % 60;

            Console.WriteLine($"{minutes}:{seconds:D2}");
        }
    }
}