namespace _04.NumberOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();

            if (@operator == "+")
            {
                Console.WriteLine($"{a} {@operator} {b} = {(a + b):F2}");
            }
            else if (@operator == "-")
            {
                Console.WriteLine($"{a} {@operator} {b} = {(a - b):F2}");
            }
            else if (@operator == "*")
            {
                Console.WriteLine($"{a} {@operator} {b} = {(a * b):F2}");
            }
            else
            {
                Console.WriteLine($"{a} {@operator} {b} = {(a / b):F2}");
            }
        }
    }
}