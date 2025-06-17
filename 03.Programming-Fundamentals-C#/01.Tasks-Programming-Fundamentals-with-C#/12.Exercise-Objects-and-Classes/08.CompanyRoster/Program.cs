using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }

    public Employee(string name, decimal salary, string department)
    {
        Name = name;
        Salary = salary;
        Department = department;
    }
}

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        List<Employee> employees = new List<Employee>();

        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            string name = input[0];
            decimal salary = decimal.Parse(input[1]);
            string department = input[2];
            employees.Add(new Employee(name, salary, department));
        }

        var departmentSalaries = employees
            .GroupBy(e => e.Department)
            .Select(g => new
            {
                Department = g.Key,
                AverageSalary = g.Average(e => e.Salary),
                Employees = g.ToList()
            })
            .OrderByDescending(g => g.AverageSalary)
            .First();

        Console.WriteLine($"Highest Average Salary: {departmentSalaries.Department}");

        foreach (var employee in departmentSalaries.Employees.OrderByDescending(e => e.Salary))
        {
            Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
        }
    }
}
