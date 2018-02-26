using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Data:List<Student>
    {
        public static event Action addElemt;
    }
}
