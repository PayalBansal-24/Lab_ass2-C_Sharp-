using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public partial class Person11
    {
        public void PrintFullName()
        {
            string fullName = ($"{FirstName} {LastName}");
            Console.WriteLine($"Full Name: {fullName}");
        }

        static void Main(string[] args)
        {
            Person11 person = new Person11
            {
                FirstName = "Payal",
                LastName = "Bansal"
            };

            person.PrintFullName(); // Calls the PrintFullName method

            // You can also access properties individually
            Console.WriteLine($"First Name: {person.FirstName}");
            Console.WriteLine($"Last Name: {person.LastName}");

            Console.ReadKey();
        }
    }
}

