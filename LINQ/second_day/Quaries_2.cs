using LINQ.second_day.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.second_day
{
    internal class Quaries_2
    {
        public static void Run()
        {
            //var students = Student.GetAllStudents()
            //        .Select(x => x)
            //        .OrderBy(x => x.FirstName)
            //        .ThenByDescending(x => x.Course)
            //        .ThenBy(x => x.Contract)
            //        .ThenByDescending(x => x.Age)
            //        .ToList();



            //foreach (var student in students)
            //{
            //    Console.WriteLine(student.FirstName + " : " + student.Course + ":" + student.Contract + " : " + student.Age);
            //}

            //var students = Student.GetAllStudents()
            //        .Select(x => x)
            //        .Average(x => x.Contract);

            //Console.WriteLine(students);

            var students = Student.GetAllStudents()
                                .Where(x => x.Lesson.ToLower() == "sirtqi");
            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName,student.LastName,student.Lesson);
            }
        }
    }
}
