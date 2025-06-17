int n = int.Parse(Console.ReadLine());

List<Student> students = new List<Student>();


for (int i = 0; i < n; i++)
{
    Student student = new Student();
    string command = Console.ReadLine();
    string[] splittedCommand = command.Split();


    string firstName = splittedCommand[0];
    string lastName = splittedCommand[1];
    string grade = splittedCommand[2];
    double myStr = double.Parse(grade);

    student.FirstName = firstName;
    student.LastName = lastName;
    student.Grade = myStr;

    students.Add(student);

}
students = students.OrderByDescending(a => a.Grade).ToList();
foreach (Student student in students)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
}





class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }
}