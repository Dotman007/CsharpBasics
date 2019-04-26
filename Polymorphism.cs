using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class Polymorphism
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullInfo()
        {
            Console.WriteLine(FirstName + " "+ LastName);
        }
    }

    public class FullTimeEmloyee : Polymorphism
    {
        
        public override void PrintFullInfo()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class NotFullTimeEmployee : Polymorphism
    {
        
        public override void PrintFullInfo()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class TemporaryEmployee : Polymorphism
    {
        public override void PrintFullInfo()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
