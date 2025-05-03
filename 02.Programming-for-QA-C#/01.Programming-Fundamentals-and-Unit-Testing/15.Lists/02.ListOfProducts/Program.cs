
int n = int.Parse(Console.ReadLine());

List<string> listOfProducts = new List<string>();

for (int i = 0; i < n; i++)
{
    string product = Console.ReadLine();

    listOfProducts.Add(product);
}

listOfProducts.Sort();

// Пешачатане на листа с for цикъл
for (int i = 0; i < listOfProducts.Count; i++)
{
    Console.WriteLine($"{i + 1}.{listOfProducts[i]}");
}

// Пешачатане на листа с foreach цикъл
int counter = 1;
foreach (string product in listOfProducts)
{
    Console.WriteLine($"{counter}.{product}");
    counter++;
}