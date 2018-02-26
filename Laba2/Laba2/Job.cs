using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Job
    {
        public string company { get; set; }
        public string position { get; set; }
        public double expirience { get; set; }

        public Job(string _company, string _position, double _expirience)
        {
            company = _company;
            position = _position;
            expirience = _expirience;
        }

    }
}
