using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_HW05_Brizhak_01
{
    class Rectangle : IFig
    {
        public void Draw(Graphics g, int x, int y, int width, int height)
        {
            
            g.DrawRectangle(Pens.Brown, x, y, width, height);
        }
    }
}
