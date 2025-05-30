using System.Runtime.InteropServices;

int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();



if (array.Length == 4)
{
    if (array[0] > array[1] && array[0] > array[2] && array[0] > array[3])
    {
        Console.Write($"{array[0]} ");
    }
    if (array[1] > array[2] && array[1] > array[3])
    {
        Console.Write($"{array[1]} ");
    }
    if (array[2] > array[3])
    {
        Console.Write($"{array[2]} ");
    }
    Console.Write($"{array[3]}");

}
else if (array.Length == 5)
{
    if (array[0] > array[1] && array[0] > array[2] && array[0] > array[3] && array[0] > array[4])
    {
        Console.Write($"{array[0]} ");
    }
    if (array[1] > array[2] && array[1] > array[3] && array[1] > array[4])
    {
        Console.Write($"{array[1]} ");
    }
    if (array[2] > array[3] && array[2] > array[4])
    {
        Console.Write($"{array[2]} ");
    }
    if (array[3] > array[4])
    {
        Console.Write($"{array[3]} ");
    }
    Console.Write($"{array[4]}");
}
else if (array.Length == 6)
{
    if (array[0] > array[1] && array[0] > array[2] && array[0] > array[3] && array[0] > array[4] && array[0] > array[5])
    {
        Console.Write($"{array[0]} ");
    }
    if (array[1] > array[2] && array[1] > array[3] && array[1] > array[4] && array[1] > array[5])
    {
        Console.Write($"{array[1]} ");
    }
    if (array[2] > array[3] && array[2] > array[4] && array[2] > array[5])
    {
        Console.Write($"{array[2]} ");
    }
    if (array[3] > array[4] && array[3] > array[5])
    {
        Console.Write($"{array[3]} ");
    }
    if (array[4] > array[5])
    {
        Console.Write($"{array[4]} ");
    }
    Console.Write($"{array[5]}");
}
else if (array.Length == 7)
{
    if (array[0] > array[1] && array[0] > array[2] && array[0] > array[3] && array[0] > array[4] && array[0] > array[5] && array[0] > array[6])
    {
        Console.Write($"{array[0]} ");
    }
    if (array[1] > array[2] && array[1] > array[3] && array[1] > array[4] && array[1] > array[5] && array[1] > array[6])
    {
        Console.Write($"{array[1]} ");
    }
    if (array[2] > array[3] && array[2] > array[4] && array[2] > array[5] && array[2] > array[6])
    {
        Console.Write($"{array[2]} ");
    }
    if (array[3] > array[4] && array[3] > array[5] && array[3] > array[6])
    {
        Console.Write($"{array[3]} ");
    }
    if (array[4] > array[5] && array[4] > array[6])
    {
        Console.Write($"{array[4]} ");
    }
    if (array[5] > array[6])
    {
        Console.Write($"{array[5]} ");
    }
    Console.Write($"{array[6]}");
}