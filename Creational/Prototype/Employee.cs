namespace Prototype
{
    public class Employee : IEmployee
    {

        public string Name { get; set; }

        public int Age { get; set; }

        public string EmploymentType { get; set; }

        public IEmployee CloneEmployee()
        {
            return this.MemberwiseClone() as IEmployee;
        }
    }
}
