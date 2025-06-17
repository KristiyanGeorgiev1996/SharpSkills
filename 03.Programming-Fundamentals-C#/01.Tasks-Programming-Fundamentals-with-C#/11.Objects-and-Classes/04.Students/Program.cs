using System.ComponentModel;

List<Student> student = new List<Student>();

while (true)
{
    string command = Console.ReadLine();
    if (command == "end")
    {
        break;
    }
    else
    {
        Student studentX = new Student();
        string[] commandArray = command.Split(" ");
        string firstName = commandArray[0];
        string lastName = commandArray[1];
        string age = commandArray[2];
        string homeTown = commandArray[3];

        studentX.FirstName = firstName;
        studentX.LastName = lastName;
        studentX.Age = age;
        studentX.HomeTown = homeTown;

        student.Add(studentX);
    }
}

string city = Console.ReadLine();

foreach (Student studentX in student)
{
    if (studentX.HomeTown == city)
    {
        Console.WriteLine($"{studentX.FirstName} {studentX.LastName} is {studentX.Age} years old.");
    }
}

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Age { get; set; }
    public string HomeTown { get; set; }
}