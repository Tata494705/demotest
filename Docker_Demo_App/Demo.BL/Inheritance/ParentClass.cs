using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL.Inheritance
{
    public class ParentClass
    {
        public ParentClass() {

            Console.WriteLine("This is parent constructor");

        }
        public void print()
        {
            Console.WriteLine("I am parent class");
        }

    }
    
    public class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("I am child constructor");
        }
    }
}
