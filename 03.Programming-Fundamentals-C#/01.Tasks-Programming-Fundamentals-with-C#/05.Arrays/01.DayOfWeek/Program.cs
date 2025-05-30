string[] daysOfWeek = ("Monday Tuesday Wednesday Thursday Friday Saturday Sunday").Split();

for (int i = 0; i < daysOfWeek.Length; i++)
{
    int n = int.Parse(Console.ReadLine());
    if (n >= 1 && n <= 7)
    {
        Console.WriteLine(daysOfWeek[n - 1]);
        break;
    }
    else
    {
        Console.WriteLine("Invalid day!");
        break;
    }
}