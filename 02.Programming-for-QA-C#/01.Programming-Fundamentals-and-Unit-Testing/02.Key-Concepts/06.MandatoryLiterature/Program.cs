
// Input

int countOfPagesToRead = int.Parse(Console.ReadLine());
int pagesReadPerOneHour = int.Parse(Console.ReadLine());
int countOfDays = int.Parse(Console.ReadLine());

// Calculations

// целочислено деление без остатък
int neededHours = countOfPagesToRead / pagesReadPerOneHour;

int readingHoursPerDay = neededHours / countOfDays;

// Output

Console.WriteLine(readingHoursPerDay);