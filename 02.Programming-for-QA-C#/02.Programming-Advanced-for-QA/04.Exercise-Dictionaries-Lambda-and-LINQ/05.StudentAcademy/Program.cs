
Dictionary<string, List<double>> students = new();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(name))
    {
        students.Add(name, new List<double>());
    }

    students[name].Add(grade);
}

// ако искаме да филтрираме речника преди foreach, но губим данни в оригиналния речник
//students = students.Where(s => s.Value.Average() >= 4.50).ToDictionary(t => t.Key, t => t.Value);


// филтрираме речника само за foreach, без да губим данни в оригиналния речник
foreach (var kvp in students.Where(s => s.Value.Average() >= 4.50))
{
    string studentName = kvp.Key;
    double averageGrade = kvp.Value.Average();

    Console.WriteLine($"{studentName} -> {averageGrade:F2}");
}