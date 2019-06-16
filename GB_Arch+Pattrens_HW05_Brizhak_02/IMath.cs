using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Pattrens_HW05_Brizhak_02
{
    /// <summary>
    /// Интерфейс для реализации методов класса Math
    /// </summary>
    public interface IMath
    {
        int add(int x, int y);
        int Sub(int x, int y);
        int Mul(int x, int y);
        int Div(int x, int y);
    }
}
