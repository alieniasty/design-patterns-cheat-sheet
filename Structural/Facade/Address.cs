using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Address
    {
        public string Street { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public string GetStreet()
        {
            return Street;
        }

        public string GetZipCode()
        {
            return ZipCode;
        }

        public string GetCity()
        {
            return City;
        }
    }
}
