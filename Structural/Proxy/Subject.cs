using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Subject : AbstractSubject
    {
        public override void Request()
        {
            Console.WriteLine("Terefere");
        }
    }
}
