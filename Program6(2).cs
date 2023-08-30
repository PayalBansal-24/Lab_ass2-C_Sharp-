using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee1
{
        public partial class Employee11
        {
            public int EmployeeId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double BaseSalary { get; set; }
            public int YearsOfWork { get; set; }
        static void Main(string[] args)
        {
            Employee11 employee = new Employee11
            {
                EmployeeId = 1,
                FirstName = "Payal",
                LastName = "Bansal",
                BaseSalary = 50000,
                YearsOfWork = 7
            };

            employee.DisplayEmployeeDetails();
            Console.ReadKey();
        }
    }
    
}

