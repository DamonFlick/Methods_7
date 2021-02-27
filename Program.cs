using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { firstName = "Sample", lastName = "Student", ID = 1 };
            Employee employee2 = new Employee() { firstName = "Sample", lastName = "Student", ID = 2 };
            //employee1.SayName();
            //Console.ReadLine();

            ////Begin Assignment pg. 247

            //employee.Quit();
            //Console.ReadLine();

            //IQuittable quit = new Employee() { firstName = "Martha", lastName = "Marsh" };
            //quit.Quit();
            //Console.ReadLine();

            Console.WriteLine(Convert.ToString(employee1==employee2));        // Assignment pg. 252
            Console.ReadLine();
            
        }
    }
}
