int n = int.Parse(Console.ReadLine());
int x = int.Parse(Console.ReadLine());
int area = 0;
RectangleArea(n, x);

void RectangleArea(int n, int x)
{
    area = n * x;
    Console.WriteLine(area);
}