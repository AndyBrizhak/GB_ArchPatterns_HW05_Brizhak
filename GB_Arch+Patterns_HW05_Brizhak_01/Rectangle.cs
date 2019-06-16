﻿using System.Drawing;

namespace GB_Arch_Patterns_HW05_Brizhak_01
{
    /// <summary>
    /// Класс для отрисовки фугуры Прямоугольник
    /// </summary>
    class Rectangle : IShape
    {
        public void Draw(Graphics g, int x, int y, int width, int height)
        {
            
            g.DrawRectangle(Pens.Brown, x, y, width, height);
        }
    }
}
