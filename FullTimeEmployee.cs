namespace CSharpBasics
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee()
        {
            MonthlySalary = 3000000;
        }
        
        public decimal MonthlySalary { get; set; }

        //Hiding Base Class Method
        
        //public void GetFullInfo(FullTimeEmployee fullTimeEmployee)
        //{
        //    Console.WriteLine(fullTimeEmployee.FirstName + '\n' + fullTimeEmployee.LastName + '\n' + fullTimeEmployee.Email);
        //}
    }
}
