using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public float Salary { get; set; }
        public string Possition { get; set; }
        public List<string> ProgrammingLanguages { get; set; }
        public static List<Employee> GetEmployee()
        {
            var employees = new List<Employee>()
            {
                new Employee {Id = 1,Name = "Aziz",LastName = "Akhunov",Age = 17,Salary = 50000,Possition = "TeamLead",ProgrammingLanguages  = new List<string>{ "C#","Python"} },
                new Employee {Id = 2,Name = "Akbar",LastName = "Oxunov",Age = 24,Salary = 100,Possition = "Junior",ProgrammingLanguages  = new List<string>{ "Java"}},
                new Employee {Id = 3,Name = "Nurmuxammad",LastName = "Sharobbiddinov",Age = 21,Salary = 500,Possition = "Middle",ProgrammingLanguages  = new List<string>{"JavaScript"}},
                new Employee {Id = 4,Name = "Azizbek",LastName = "Rahmatullayev",Age = 23,Salary = 150,Possition = "StrongJunior",ProgrammingLanguages  = new List<string>{ "C++"}}
            };
            return employees;
        }
    }
}
