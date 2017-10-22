using System;

namespace InheritanceDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student
            {
                Age = 15,
                Grade = "Fourth",
                Name = "John"
            };

            var scienceStudent = new ScienceStudentDecorator(student)
            {
                Labs = "Biology, History, Physics"
            };

            Console.WriteLine(scienceStudent.DisplayInformation());

            Console.Read();
        }
    }
}
