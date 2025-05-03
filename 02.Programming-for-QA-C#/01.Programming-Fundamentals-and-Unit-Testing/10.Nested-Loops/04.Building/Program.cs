
int countOfFloors = int.Parse(Console.ReadLine());
int countOfRooms = int.Parse(Console.ReadLine());

for (int floor = countOfFloors; floor >= 1; floor--)
{
    for (int room = 0; room < countOfRooms; room++)
    {
        if (floor == countOfFloors) // проверка дали сме на последния етаж
        {
            Console.Write($"L{floor}{room} ");
        }
        else if (floor % 2 == 0) // проветка дали сме на четен етаж
        {
            Console.Write($"O{floor}{room} ");
        }
        else if (floor % 2 == 1) // проверка дали сме на нечетен етаж
        {
            Console.Write($"A{floor}{room} ");
        }
    }

    Console.WriteLine();
}