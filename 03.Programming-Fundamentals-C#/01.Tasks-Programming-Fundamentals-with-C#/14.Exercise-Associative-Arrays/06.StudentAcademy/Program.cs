using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var students = new Dictionary<string, List<double>>();

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());

            if (!students.ContainsKey(name))
            {
                students[name] = new List<double>();
            }

            students[name].Add(grade);
        }

        foreach (var student in students)
        {
            double averageGrade = student.Value.Average();
            if (averageGrade >= 4.50)
            {
                Console.WriteLine($"{student.Key} -> {averageGrade:F2}");
            }
        }
    }
}
