
double grade = double.Parse(Console.ReadLine());

PrintGradeInWord(grade);

static void PrintGradeInWord(double grade)
{
    string gradeInWords = "";

    switch (grade)
    {
        case >= 2 and <= 2.99:
            gradeInWords = "Fail";
            break;
        case >= 3 and <= 3.49:
            gradeInWords = "Average";
            break;
        case >= 3.50 and <= 4.49:
            gradeInWords = "Good";
            break;
        case >= 4.50 and <= 5.49:
            gradeInWords = "Very good";
            break;
        case >= 5.50 and <= 6.00:
            gradeInWords = "Excellent";
            break;
    }

    Console.WriteLine(gradeInWords);
}