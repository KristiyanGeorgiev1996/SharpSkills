
string destination = Console.ReadLine();

while (destination != "End")
{
    // прочитам необходимата сума за дестинацията
    double neededMoney = double.Parse(Console.ReadLine());
    double savedMoney = 0;

    // четем пари от конзолата докато не съберем необходимата сума
    while (savedMoney < neededMoney)
    {
        double currentMoney = double.Parse(Console.ReadLine());
        // прибавяме текущите пари към спестените
        savedMoney += currentMoney;

        Console.WriteLine($"Collected: {savedMoney:F2}");
    }

    // имаме достатъчно пати и изписваме, че заминаваме за дестинацията
    Console.WriteLine($"Going to {destination}!");

    // четем нова дестинация
    destination = Console.ReadLine();
}