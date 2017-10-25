using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class AddressFacade
    {
        private readonly Address _address;

        public AddressFacade()
        {
            _address = new Address();
        }

        public void SetAddress(string city, string street, string zipCode)
        {
            _address.City = city;
            _address.Street = street;
            _address.ZipCode = zipCode;
        }

        public string GetAddress()
        {
            return $"{_address.Street} {_address.ZipCode} {_address.City}";
        }
    }
}
