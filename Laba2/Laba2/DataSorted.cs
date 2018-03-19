using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Laba2
{
    public class DataSorted
    {
        public List<Student> SortedByName;
        public List<Student> SortedByNacionDate;
        public List<Student> SortedByLayer;
        public List<Student> SortedByGroup;
        public List<Student> SortedBySR;
        public List<Student> SortedBySpec;
        public DataSorted(Data students)
        {
            SortedByName = students;
            SortedByNacionDate = students;
            SortedByLayer = students;
            SortedByGroup = students;
            SortedBySR = students;
            SortedBySpec = students;



            SortedByName.Sort((a, b) => a.FullName.CompareTo(b.FullName));
            SortedByNacionDate.Sort((a, b) => a.nacionDate.CompareTo(b.nacionDate));
            SortedByLayer.Sort((a, b) => a.UniversityLayer.CompareTo(b.UniversityLayer));
            SortedByGroup.Sort((a, b) => a.Group.CompareTo(b.Group));
            SortedBySR.Sort((a, b) => a.AverageScort.CompareTo(b.AverageScort));
            SortedBySpec.Sort((a, b) => a.Spec.CompareTo(b.Spec));
        }
        public void SaveSortedData(string path)
        {
            printList(path, SortedByName);
            printList(path, SortedByNacionDate);
            printList(path, SortedByLayer);
            printList(path, SortedByGroup);
            printList(path, SortedBySR);
            printList(path, SortedBySpec);
        }

        

        private void printList(string path,List<Student> students)
        {
            using (StreamWriter streamWriter = new StreamWriter(path,true,System.Text.Encoding.Default))
            {
               foreach(var item in students)
                {
                    streamWriter.WriteLine(item.ToString());
                }
            }
        }
        
    }
}
