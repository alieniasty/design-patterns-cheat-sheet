using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    /*Prevents 'if (product != null) then blah blah'*/
    public class NullProduct : AbstractProduct
    {
        public override void RateProduct(int stars)
        {
            // null object
        }
    }
}
