namespace _07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            bool workingDay = day != "Sunday";
            bool workingHour = hour >= 10 && hour <= 18;
            if (workingDay && workingHour)
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}