namespace InheritanceDecorator
{
    public class ScienceStudentDecorator : StudentDecorator
    {
        public string Labs { get; set; }

        public ScienceStudentDecorator(Student student) : base(student)
        {
        }

        public override string DisplayInformation()
        {
            var info = base.DisplayInformation();
            return $"{info}. Labse are {Labs}";
        }
    }
}