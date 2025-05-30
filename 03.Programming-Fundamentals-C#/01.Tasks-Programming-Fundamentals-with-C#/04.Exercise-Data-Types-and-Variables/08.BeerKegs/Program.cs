int countKegs = int.Parse(Console.ReadLine());

string biggestModelName = "";
double biggestKegObem = 0;

for (int i = 1; i <= countKegs; i++)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int high = int.Parse(Console.ReadLine());

    double volume = Math.PI * (Math.Pow(radius, 2)) * high;
    if (biggestKegObem < volume)
    {
        biggestKegObem = volume;
        biggestModelName = model;

    }
}
Console.WriteLine(biggestModelName);
