namespace _02.ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = int.Parse(Console.ReadLine());
            int withdraw = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());

            // withdraw --> limit --> balance
            if (withdraw > limit)
            {
                Console.WriteLine("The limit was exceeded.");
            }
            else if (withdraw > balance)
            {
                Console.WriteLine($"Insufficient availability.");
            }
            else
            {
                Console.WriteLine("The withdraw was successful.");
            }
        }
    }
}