using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL.Abstraction
{
   public abstract class Animal
    {
        public abstract void eat();
        public void sound()
        {
            Console.WriteLine("dog can sound!");
        }
    }

    public class dog:Animal
    {
        public override void eat()
        {
            Console.WriteLine("dog can eat!");
        }

    }
}
