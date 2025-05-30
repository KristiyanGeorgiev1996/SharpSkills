decimal lenght = decimal.Parse(Console.ReadLine());
decimal width = decimal.Parse(Console.ReadLine());
decimal height = decimal.Parse(Console.ReadLine());

decimal V1 = lenght * width * height;
decimal V = V1 / 3;

Console.Write("Length:");
Console.Write(" Width:");
Console.Write(" Height:");
Console.Write($" Pyramid Volume: {V:f2}");