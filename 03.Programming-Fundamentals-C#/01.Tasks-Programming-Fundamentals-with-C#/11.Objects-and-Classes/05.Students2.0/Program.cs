﻿string command = Console.ReadLine();
List<Student> students = new List<Student>();
while (command != "end")
{
    string[] tokens = command.Split();
    string firstName = tokens[0];
    string lastName = tokens[1];
    int age = int.Parse(tokens[2]);
    string city = tokens[3];

    if (IsStudentExisting(students, firstName, lastName))
    {
        GetStudent(students, firstName, lastName, age);

    }
    else
    {
        Student student = new Student()
        {
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            City = city,

        };
        students.Add(student);
    }

    command = Console.ReadLine();
}
string filterCity = Console.ReadLine();
List<Student> filteredStudents = students.Where(s => s.City == filterCity).ToList();

foreach (Student student in filteredStudents)
{

    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
}

static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
{
    foreach (Student student in students)
    {
        if (student.FirstName == firstName && student.LastName == lastName)
        {
            return true;
        }
    }
    return false;
}

static void GetStudent(List<Student> students, string firstName, string lastName, int age)
{

    foreach (Student student in students)
    {
        if (student.FirstName == firstName && student.LastName == lastName)
        {
            student.FirstName = firstName;
            student.LastName = lastName;
            student.Age = age;
            student.City = student.City;

        }
    }

}

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}
