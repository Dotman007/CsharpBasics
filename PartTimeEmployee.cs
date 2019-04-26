using System;

namespace CSharpBasics
{
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee()
        {
            HourlySalary = 300000;
        }
        public decimal HourlySalary { get; set; }
        public new void GetFullInfo(Employee employee)
        {
            Console.WriteLine("Hiding the base class method and displaying it in the partTimeEmployee class");
            base.GetFullInfo(employee);
        }
    }
}
