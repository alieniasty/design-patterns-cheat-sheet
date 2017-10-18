using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee
            {
                Age = 22,
                EmploymentType = "Contract",
                Name = "Adriano Italiano"
            };

            /*
             * Check if is of type Employee AND not null. Pattern matching
             */
            if (!(employee.CloneEmployee() is Employee anotherEmployee)) return; 
            anotherEmployee.Name = "Adriano Polano";
            anotherEmployee.Age = 32;
            anotherEmployee.EmploymentType = "Intern";

            Console.WriteLine(employee.Name);
            Console.WriteLine(anotherEmployee.Name);

            Console.ReadLine();
        }
    }
}