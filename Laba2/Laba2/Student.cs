using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Laba2
{   


    public class Student
    {
        public string FullName;

        public int age;
        public DateTime nacionDate;
        public int UniversityLayer;
        public int Group;
        public int AverageScort;
        public string Spec;

        public string Sex;
        public Adress adress;
        public Job job;
        public string Index;
       
        public Student(    string name,
                           int age,
                           DateTime date,
                           string _spec,
                           int layer,
                           int group,
                           int score,
                           string sex,
                           Adress _adress,
                           Job _job
                          
                        
                        )
        {
            FullName = name;
            this.age = age;
            Spec = _spec;
            nacionDate = date;
            UniversityLayer = layer;
            Group = group;
            AverageScort = score;
            Sex = sex;
            adress = _adress;
            job = _job;
            Index = name + _spec + layer.ToString() + score.ToString();

        }
        public override string ToString()
        {
            return "Name:" + FullName + " specialty:" + Spec + " layer:" + UniversityLayer.ToString() + " Score:" + AverageScort.ToString();
        }
    }
}
