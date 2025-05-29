string country = Console.ReadLine();

if (country == "USA" || country == "England")
{
    Console.WriteLine("English");
}
else if (country == "Spain" || country == "Argentina" || country == "Mexico")
{
    Console.WriteLine("Spanish");
}
else
{
    Console.WriteLine("unknown");
}