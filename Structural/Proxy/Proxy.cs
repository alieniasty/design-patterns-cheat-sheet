using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    /*Instead of making multiple copies of a heavy object X you make copies of a lightweight proxy P which in turn manages X and translates your calls as required.) 
     * You are solving the problem of the client from having to manage a heavy and/or complex object.*/
    class Proxy : Subject
    {
        private Subject _realSubject;

        public override void Request()
        {
            /*Use 'lazy initialization'*/
            if (_realSubject == null)
            {
                _realSubject = new Subject();
            }

            _realSubject.Request();
        }
    }
}
