using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL.Polymorphism
{
    public class Overloading
    {
     
        public void testdata(int a, int b)
        {
            Console.WriteLine("Total a + b : " + (a + b));
        }

        public void testdata(int a, int b, int c)
        {
            Console.WriteLine("Total a + b + c : " + (a + b + c));
        }
    }
}
