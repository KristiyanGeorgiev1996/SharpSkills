namespace _02.CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            double days = Math.Round(years * 365.2422);
            double hours = days * 24;
            double minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}