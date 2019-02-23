using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP
{
    public class Employee
    {
        private readonly string FullName;
        private readonly int    Hours;
        private readonly double Rate;

        public Employee(string fullname, int hours, double rate)
        {
            FullName = fullname;
            Hours    = hours;
            Rate     = rate;
        }

        public double CalcualteSalary ()
        {
            double TotalSalary = (Hours * Rate) * 30;
            return TotalSalary;
        }

        public void PrintSlip()
        {
            Console.WriteLine("The Slip");
            Console.WriteLine("=========");
            Console.WriteLine("Name: {0}", FullName);
            Console.Write("Salary: {0} USD", CalcualteSalary());
        }
    }
}
