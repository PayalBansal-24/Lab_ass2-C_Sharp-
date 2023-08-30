using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee1
{
        public partial class Employee11
        {
            public double CalculateSalary()
            {
                double salary = BaseSalary;

                if (YearsOfWork >= 5)
                {
                    salary += 1000;
                }

                return salary;
            }

            public void DisplayEmployeeDetails()
            {
                Console.WriteLine("Employee ID:" +EmployeeId);
                Console.WriteLine("Name:" +FirstName +" " +LastName);
                Console.WriteLine("Base Salary:" +BaseSalary);
                Console.WriteLine("Years of Work:" +YearsOfWork);
                Console.WriteLine("Calculated Salary:" +CalculateSalary());
            }
        }
 
}
