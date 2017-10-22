namespace AbstractDecorator
{
    public class Student : IStudent
    {
        public string Name { get; set; }

        public string Grade { get; set; }

        public int Age { get; set; }

        public string DisplayInformation()
        {
            return $"{Name} - {Age} years old is in {Grade} grade";
        }
    }
}
