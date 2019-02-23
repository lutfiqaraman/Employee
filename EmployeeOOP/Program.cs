using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "John Dark";
            int Hours = 10;
            double Rate = 15.75;

            Employee Emp1 = new Employee(Name, Hours, Rate);
            Emp1.PrintSlip();

            Console.ReadKey();
        }
    }
}
