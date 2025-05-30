int lostGames = int.Parse(Console.ReadLine());
double priceOfSlushalki = double.Parse(Console.ReadLine());
double priceOfMouse = double.Parse(Console.ReadLine());
double priceOfKlaviatura = double.Parse(Console.ReadLine());
double priceOfDisplay = double.Parse(Console.ReadLine());

double allSumForNew = 0;

if (lostGames >= 2)
{
    double breakSlushalki = lostGames / 2;
    double newSlushalki = Math.Abs(breakSlushalki);
    double smetka = newSlushalki * priceOfSlushalki;
    allSumForNew += smetka;
}
if (lostGames >= 3)
{
    double breakMouses = lostGames / 3;
    double newMouses = Math.Abs(breakMouses);
    double smetka = newMouses * priceOfMouse;
    allSumForNew += smetka;
}
if (lostGames >= 6)
{
    double breakKlaviatura = lostGames / 6;
    double newKlaviatura = Math.Abs(breakKlaviatura);
    double smetka = newKlaviatura * priceOfKlaviatura;
    allSumForNew += smetka;
}
if (lostGames >= 12)
{
    double breakDisplay = lostGames / 12;
    double newDisplay = Math.Abs(breakDisplay);
    double smetka = newDisplay * priceOfDisplay;
    allSumForNew += smetka;
}

Console.WriteLine($"Rage expenses: {allSumForNew:F2} lv.");

