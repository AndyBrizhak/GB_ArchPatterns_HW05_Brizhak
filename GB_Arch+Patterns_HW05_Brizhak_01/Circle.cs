﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_HW05_Brizhak_01
{
    public class Circle : IFig
    {
        public void Draw(Graphics g, int x, int y, int width, int height)
        {
            
           g.DrawEllipse(Pens.Green, x, y, width, height);
        }
    }
}