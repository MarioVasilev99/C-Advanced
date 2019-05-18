namespace CompanyRoster_P06
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int employeesCount = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            // Read and Assing employees into list
            for (int i = 0; i < employeesCount; i++)
            {
                string[] employeeData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = employeeData[0];
                double salary = double.Parse(employeeData[1]);
                string position = employeeData[2];
                string department = employeeData[3];

                if (employeeData.Length == 6)
                {
                    string email = employeeData[4];
                    int age = int.Parse(employeeData[5]);

                    Employee newEmployee = new Employee(
                        name,
                        salary,
                        position,
                        department,
                        email,
                        age);

                    employees.Add(newEmployee);
                }
                else if (employeeData.Length == 5)
                {
                    string employeeProperty = employeeData[4];
                    int age;

                    bool isAgeOrEmail = int.TryParse(employeeProperty, out age);

                    // If True -> The property is the Age; Else -> The property is the Email
                    if (isAgeOrEmail) 
                    {
                        Employee newEmployee = new Employee(
                            name,
                            salary,
                            position,
                            department,
                            age);

                        employees.Add(newEmployee);
                    }
                    else
                    {
                        string email = employeeData[4];

                        Employee newEmployee = new Employee(
                            name,
                            salary,
                            position,
                            department,
                            email);

                        employees.Add(newEmployee);
                    }
                }
                else if (employeeData.Length == 4)
                {
                    Employee newEmployee = new Employee(name, salary, position, department);

                    employees.Add(newEmployee);
                }
            }

            var bestDepartment = employees
                .GroupBy(e => e.Department)
                .OrderByDescending(d => d.Select(e => e.Salary).Average())
                .FirstOrDefault()
                .Key;

            Console.WriteLine($"Highest Average Salary: {bestDepartment}");

            foreach (var employee in employees
                .Where(x => x.Department == bestDepartment)
                .OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}