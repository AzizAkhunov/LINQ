using LINQ.Third_day.Models;

namespace LINQ.Third_day
{
    public class Quaries_3
    {
        public static void Run()
        {                           //GROUP BY
            

            //var result = from kid in Kids.GetAllKids
            //             group kid by kid.Age;

            //foreach(var kid in result)
            //{
            //    Console.WriteLine($"Keyi buyicha: {kid.Key}");
            //    foreach(var kd in kid)
            //    {
            //        Console.WriteLine(kd.Name);
            //    }
            //}
                                  //JOIN
            var kids = Kids.GetAllKids();
            var teacher = Teachers.GetAllTeachers();

            var result = teacher.GroupJoin(kids,
                teacher => teacher.TechCourse,
                kid => kid.Course,
                (parent, child) => new
                {
                    KidsList = child,
                    TeacherName = parent.FirstName,
                });
            foreach(var item in result)
            {
                Console.WriteLine(item.TeacherName);
                foreach(var student in item.KidsList)
                {
                    Console.WriteLine($"Student Name: {student.Name}");
                }
            }
            
        }
    }
}
