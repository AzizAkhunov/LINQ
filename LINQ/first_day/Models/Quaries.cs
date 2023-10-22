using LINQ.Models;

namespace LINQ
{
    internal class Quaries
    {
        public static void Run()
        {
            /* Syntaxes
            List<int> numbers = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 1234, 4458 };

            ////Method Syntax

            //IEnumerable<int> query = numbers.Where(x => x % 2 == 0) .ToList();

          
            //Query syntax

            //var query = from number in numbers
            //            where number % 2 == 0    //select * from numbers where x % 2 == 0;
            //            select number;
            
            //Mixed syntax

            var query = (from  number in numbers select number).Where(number => number % 2 == 0);


            foreach (int number in query)
            {
                Console.WriteLine(number);
            }
            */

            //var employeeSalary = (from employee in Employee.GetEmployee()
            //                       select (employee.Name,employee.LastName,employee.Salary * 12)).ToList();

            //List<float> salaries = new List<float>();

            //foreach (var employee in employeeSalary)
            //{
            //    Console.WriteLine(employee);
            //    salaries.Add(employee.Item3);
            //}
            //Console.WriteLine(salaries.Max());

            var employeeLanguages = Employee.GetEmployee().SelectMany(x => x.ProgrammingLanguages ,
                (parent,child) => new
                {
                    Name = parent.Name,
                    Language = child
                } 
                ).ToList();
            
            foreach (var language in employeeLanguages)
            {
                Console.WriteLine(language);
            }
        }
    }
}
