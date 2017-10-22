namespace AbstractDecorator
{
    public class ScienceStudentDecorator : IStudent
    {
        private readonly IStudent _student;

        public string Labs { get; set; }

        public ScienceStudentDecorator(IStudent student)
        {
            _student = student;
        }

        public string DisplayInformation()
        {
            var info = _student?.DisplayInformation();
            return $"{info}. Labse are {Labs}";
        }
    }
}
