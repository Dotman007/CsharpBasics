using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class MethodHiding
    {
    }

    public class MethodHidingBase
    {
        public void BaseMethod()
        {
            Console.WriteLine("This is the base Method");
        }
    }

    public class MethodHidingDerived : MethodHidingBase
    {
        public new void BaseMethod()
        {
            base.BaseMethod();
        }
    }
}
