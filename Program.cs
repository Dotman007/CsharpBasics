using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            Console.WriteLine("This Belongs to my Father : " + partTimeEmployee.FirstName +" " + partTimeEmployee.LastName + " " +partTimeEmployee.Email);
            partTimeEmployee.GetFullInfo(partTimeEmployee);
            //Console.WriteLine("This belongs to me alone :" + partTimeEmployee.HourlySalary);
            Console.WriteLine("======================================="+'\n');
            Employee fullTimeEmployee = new FullTimeEmployee();
            Console.WriteLine("This Belongs to my Father : " + fullTimeEmployee.FirstName + " " + fullTimeEmployee.LastName + " " + fullTimeEmployee.Email);
            fullTimeEmployee.GetFullInfo(fullTimeEmployee);
            //Console.WriteLine("This belongs to me alone :" + fullTimeEmployee.MonthlySalary);
            Console.ReadLine();
        }
    }
}
