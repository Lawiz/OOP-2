using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Collection
    {
        public List<int> list = new List<int>();
        public Collection(int count)
        {
            Random random = new Random((int)(DateTime.Now.Ticks));
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    list.Add(random.Next(100));
                }
            }
        }



    }
}
