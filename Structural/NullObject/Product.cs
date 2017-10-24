using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    public class Product : AbstractProduct
    {
        public override void RateProduct(int stars)
        {
            Console.WriteLine($"Rate is {stars}");
        }
    }
}
