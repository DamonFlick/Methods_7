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
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            employee.SayName();
            Console.ReadLine();

            //Begin Assignment pg. 247

            employee.Quit();
            Console.ReadLine();

            IQuittable quit = new Employee() { firstName = "Martha", lastName = "Marsh" };
            quit.Quit();
            Console.ReadLine();
        }
    }
}
