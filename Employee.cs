using System;

namespace CSharpBasics
{
    public class Employee
    {
        public Employee()
        {
            FirstName = "Adedotun";
            LastName = "Salami";
            Email = "adetop99@gmail.com";
            Console.WriteLine("Employee Constructor was called");
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public void GetFullInfo(Employee employee)
        {

            Console.WriteLine(employee.FirstName +'\n' + employee.LastName +'\n' + employee.Email);
        }

    }
}
