double peoples = double.Parse(Console.ReadLine());
double maxPeople = double.Parse(Console.ReadLine());

double courses = 0;
double oneMoreCourse;

double course = peoples / maxPeople;

if (peoples % maxPeople == 0)
{
    courses += course;
}
else if (peoples % maxPeople != 0)
{
    oneMoreCourse = course;
    double ceiling = Math.Ceiling(oneMoreCourse);
    courses += ceiling;
}

Console.WriteLine(courses);
