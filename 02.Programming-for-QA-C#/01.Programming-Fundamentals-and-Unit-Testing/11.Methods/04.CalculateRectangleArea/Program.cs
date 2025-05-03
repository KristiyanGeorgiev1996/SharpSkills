
int sideA = int.Parse(Console.ReadLine());
int sideB = int.Parse(Console.ReadLine());

int area = FindRectangleArea(sideA, sideB);

Console.WriteLine(area);

static int FindRectangleArea(int sideA, int sideB)
{
    return sideA * sideB;
}