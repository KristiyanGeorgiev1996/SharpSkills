using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "end")
            {
                break;
            }

            string[] parts = input.Split(" : ");
            string courseName = parts[0];
            string studentName = parts[1];

            if (!courses.ContainsKey(courseName))
            {
                courses[courseName] = new List<string>();
            }

            courses[courseName].Add(studentName);
        }

        foreach (var course in courses)
        {
            Console.WriteLine($"{course.Key}: {course.Value.Count}");
            foreach (var student in course.Value)
            {
                Console.WriteLine($"-- {student}");
            }
        }
    }
}
