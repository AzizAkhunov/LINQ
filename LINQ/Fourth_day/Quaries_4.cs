using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Fourth_day
{
    public class Quaries_4
    {
        public static void Run()
        {
            var collection = Enumerable.Range(5, 5);//if we are using repeat Answer: 5 5 5 5 5 
            Console.WriteLine("Total count: {0}",collection.Count());

            for (int i = 0; i < collection.Count(); i++)
                Console.WriteLine("Value At Index: {0} : {1}",i,collection.ElementAt(i));
        }
    }
}
