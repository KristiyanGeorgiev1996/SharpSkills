// Input

int sideA = int.Parse(Console.ReadLine());
int sideB = int.Parse(Console.ReadLine());
int sideC = int.Parse(Console.ReadLine());

// Output

if (sideA >= sideB + sideC)
    Console.WriteLine("Invalid Triangle");
else if (sideB >= sideA + sideC)
    Console.WriteLine("Invalid Triangle");
else if (sideC >= sideA + sideB)
    Console.WriteLine("Invalid Triangle");
else
    Console.WriteLine("Valid Triangle");