using Demo.Service.Interfaces.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL.Inheritance
{
    public class Icar : IA, IB
    {
        public int amt(int i)
        {
            return i;
        }

        public string img(string a)
        { return a; }
    }
}
