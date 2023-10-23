using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Third_day.Models
{
    public class Kids
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Course { get; set; }

        public static List<Kids> GetAllKids()
        {
            List<Kids> kids = new List<Kids>()
            {
                new Kids(){ Id = 1, Name = "Akbar", Age = 24,Course = 1},
                new Kids(){ Id = 2, Name = "Sardor",Age = 19,Course = 2},
                new Kids(){ Id = 3, Name = "Nuri",  Age = 23, Course = 3},
                new Kids(){ Id = 4, Name = "Rustam",Age = 15, Course = 4},
                new Kids(){ Id = 5, Name = "Bahti", Age = 20, Course = 5}
            };
            return kids;
        }
    }
}
