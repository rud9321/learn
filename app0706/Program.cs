using app0706.Data;
using app0706.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app0706
{
    class Program
    {
        static void Main(string[] args)
        {

            var data = Storage.GetStudents().Join(Storage.GetStandards(),stu => stu.StandardId, stand => stand.Id,(stu,stand)=> new { studentname = stu.Name });

            foreach (var d in data)
                Console.WriteLine(d.studentname);
                Console.ReadLine();
        }
    }
}
