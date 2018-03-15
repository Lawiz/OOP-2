using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class DataSorted
    {
        public List<Student> SortedByName;
        public List<Student> SortedByNacionDate;
        public List<Student> SortedByLayer;
        public List<Student> SortedByGroup;
        public List<Student> SortedBySR;
        public List<Student> SoretedBySpec;
        public DataSorted()
        {
            SortedByGroup.Sort((a, b) => a.FullName.CompareTo(b.FullName));
            SortedByGroup.Sort((a, b) => a.nacionDate.CompareTo(b.nacionDate));
            SortedByGroup.Sort((a, b) => a.UniversityLayer.CompareTo(b.UniversityLayer));
            SortedByGroup.Sort((a, b) => a.Group.CompareTo(b.Group));
            SortedByGroup.Sort((a, b) => a.AverageScort.CompareTo(b.AverageScort));
            SortedByGroup.Sort((a, b) => a.Spec.CompareTo(b.Spec));


        }

    }
}
