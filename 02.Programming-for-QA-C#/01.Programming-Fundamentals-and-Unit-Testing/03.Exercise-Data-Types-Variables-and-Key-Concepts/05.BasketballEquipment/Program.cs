namespace _05.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yearlytTrainingFee = double.Parse(Console.ReadLine());

            double sneakersCost = yearlytTrainingFee * 0.6; // 40% less than Training Fee
            double uniformCost = sneakersCost * 0.8; // 20% less than Sneakers Cost
            double ballCost = uniformCost * 0.25; // 1/4 of Uniform cost.
            double accessoriesCost = ballCost * 0.2; // 1/5 of ballCost

            double totalCost = yearlytTrainingFee + sneakersCost + uniformCost + ballCost + accessoriesCost;
            Console.WriteLine(totalCost);
        }
    }
}