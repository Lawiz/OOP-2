using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Adress
    {

        public string City { get; set; }
        public string Index { get; set; }
        public string Street { get; set; }
        public int HomeNumber { get; set; }
        public int FlatNumber { get; set; }

        public Adress(string _City,string _index, string _street, int _HomeNumber, int _flatNumber)
        {
            City = _City;
            Index = _index;
            Street = _street;
            HomeNumber = _HomeNumber;
            FlatNumber = _flatNumber;
        }

    }
}
