using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDecorator
{
    public class Student : IStudent
    {
        public string Name { get; set; }

        public string Grade { get; set; }

        public int Age { get; set; }

        public virtual string DisplayInformation()
        {
            return $"{Name} - {Age} years old is in {Grade} grade";
        }
    }
}
