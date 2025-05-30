int n = int.Parse(Console.ReadLine());
int[] array = new int[n];

int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
    sum = sum + array[i];
}
for (int i = 0; i < array.Length; i++)
{
    if (i == array.Length - 1)
    {
        Console.WriteLine(array[i]);
    }
    else
    {
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine(sum);
