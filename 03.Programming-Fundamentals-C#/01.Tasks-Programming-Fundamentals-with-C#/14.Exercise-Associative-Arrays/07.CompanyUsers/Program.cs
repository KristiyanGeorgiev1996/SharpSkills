using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var companies = new Dictionary<string, HashSet<string>>();
        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] parts = input.Split(" -> ");
            string companyName = parts[0];
            string employeeId = parts[1];

            if (!companies.ContainsKey(companyName))
            {
                companies[companyName] = new HashSet<string>();
            }

            companies[companyName].Add(employeeId);
        }

        foreach (var company in companies)
        {
            Console.WriteLine(company.Key);
            foreach (var employeeId in company.Value)
            {
                Console.WriteLine($"-- {employeeId}");
            }
        }
    }
}
