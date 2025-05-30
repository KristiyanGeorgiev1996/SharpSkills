int numbers = int.Parse(Console.ReadLine());
int[] array = new int[numbers];

for (int i = 0; i < numbers; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < numbers; i++)
{
    Console.Write(array[array.Length - 1 - i] + " ");
}
