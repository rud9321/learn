using app0706.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app0706.Data
{
    public static class Storage
    {
        public static IEnumerable<Student> GetStudents()
        {
            return new List<Student>() {
                   new Student() { Id = 1, Name = "John", Age = 13,StandardId=1} ,
                   new Student() { Id = 2, Name = "Jack",  Age = 21,StandardId=2 } ,
                   new Student() { Id = 3, Name = "Bill",  Age = 18, StandardId=4 } ,
                   new Student() { Id = 4, Name = "Odelio" , Age = 20, StandardId=1} ,
                   new Student() { Id = 5, Name = "Ron" , Age = 15, StandardId=2 },
                   new Student() { Id = 6, Name = "Worner" , Age = 20 ,StandardId=1} ,
                  };

        }

        public static IEnumerable<Standard> GetStandards()
        {
            return new List<Standard>() {
            new Standard(){ Id = 1, StandardName="Standard 1"},
            new Standard(){ Id = 2, StandardName="Standard 2"},
            new Standard(){ Id = 3, StandardName="Standard 3"}
        };
        }
    }
}
