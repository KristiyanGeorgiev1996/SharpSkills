string[] arr1 = Console.ReadLine().Split();
string[] arr2 = Console.ReadLine().Split();

for (int i = 0; i < arr2.Length; i++)
{
    string temp = arr2[i];
    for (int j = 0; j < arr1.Length; j++)
    {
        if (arr1[j] == temp)
        {
            Console.Write($"{temp} ");
        }
    }
}