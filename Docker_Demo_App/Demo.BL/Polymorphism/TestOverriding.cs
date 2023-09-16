using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL.Polymorphism
{
    public class TestOverriding
    {
        public virtual double Area()
        {
            return 0;
        }
    }

    public class Cricle : TestOverriding
    {
        public double Radius { get; set; }
        public Cricle()
        {
            Radius = 5;
        }
        public override double Area()
        {
            return (3.14) * Math.Pow(Radius, 2);
        }
    }

    public class Rectangle : TestOverriding
    {
        public double Height { get; set; }
        public double Widht { get; set; }
        public Rectangle()
        {
            Height = 5.2;
            Widht = 3.4;
        }
        public override double Area()
        {
            return (Height * Widht);
        }

    }
}
