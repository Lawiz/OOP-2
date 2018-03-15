using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Laba2
{   


    public class Student
    {
        [Required(ErrorMessage ="Введите имя")]
        
        public string FullName;
        [Range(0,140,ErrorMessage ="неверный возраст")] 
        public int age;

        public DateTime nacionDate;
        [Range(1,5,ErrorMessage ="неверный курс")]
        public int UniversityLayer;
        [Range(1,10,ErrorMessage ="неверная группа")]
        public int Group;
        [Range(1,10,ErrorMessage ="неверный средний балл")]
        public int AverageScort;

        public string Sex;
        public Adress adress;
        public Job job;

        public Student(    string name,
                           int age,
                           DateTime date,
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
            nacionDate = date;
            UniversityLayer = layer;
            Group = group;
            AverageScort = score;
            Sex = sex;
            adress = _adress;
            job = _job;
            
        }
       
    }
}
