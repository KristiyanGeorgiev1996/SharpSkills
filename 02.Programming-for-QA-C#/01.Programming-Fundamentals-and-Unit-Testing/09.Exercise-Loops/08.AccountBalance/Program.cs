namespace _08.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;
            string line; //                                 -->  option 1
            while ((line = Console.ReadLine()) != "End") // -->  option 1
            //while (true) --> option 2
            {
                // option 2
                //string line = Console.ReadLine(); // End, 100, -200
                //if (line == "End")
                //{
                //    break;
                //}

                double moneyAmount = double.Parse(line);
                balance += moneyAmount;
                if (moneyAmount >= 0)
                {
                    Console.WriteLine($"Increase: {moneyAmount:F2}");
                }
                else
                {
                    Console.WriteLine($"Decrease: {Math.Abs(moneyAmount):F2}");
                }
            }

            Console.WriteLine($"Balance: {balance:F2}");
        }
    }
}