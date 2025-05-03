// Input

int daysToExam = int.Parse(Console.ReadLine());

// Output

for (int day = daysToExam; day >= 1; day--)
{
    Console.WriteLine($"{day} days before the exam");
}

Console.WriteLine("The exam has come");