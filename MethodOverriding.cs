using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class MethodOverriding
    {

    }

    public class BaseClass
    {
        //Declare the base class method as virtual so that it can be overriden.
        public virtual void Print()
        {
            Console.WriteLine("This is the base Print Method");
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("This is the derived Print Method");
        }
    }
}
