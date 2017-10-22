namespace InheritanceDecorator
{
    public class StudentDecorator : Student
    {
        private readonly Student _student;

        public StudentDecorator(Student student)
        {
            _student = student;
        }

        public override string DisplayInformation()
        {
            return _student.DisplayInformation();
        }
    }
}