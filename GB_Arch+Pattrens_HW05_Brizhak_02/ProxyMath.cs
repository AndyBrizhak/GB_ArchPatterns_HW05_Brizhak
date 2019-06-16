using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Pattrens_HW05_Brizhak_02
{
    /// <summary>
    /// Класс заместитель исходного класса Math
    /// </summary>
    class ProxyMath
    {
        Math math = new Math();

        public int Add(int x, int y)
        {
            return math.Add(x, y);
        }

        public int Sub(int x, int y)
        {
            return math.Sub(x, y);
        }

        public int Mul(int x, int y)
        {
            return math.Mul(x, y);
        }

        public int Div(int x, int y)
        {
            return math.Div(x, y);
        }

    }
}
