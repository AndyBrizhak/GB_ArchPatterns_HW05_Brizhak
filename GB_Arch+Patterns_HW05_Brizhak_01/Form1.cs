using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GB_Arch_Patterns_HW05_Brizhak_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            for (int i = 0; i < 4; i++)
            {
                IShape shape = FactoryShapes.GetShape("Circle");
                shape.Draw(e.Graphics,i+10, i+10, i+100, i+100);
            }

            for (int i = 0; i < 4; i++)
            {
                IShape shape = FactoryShapes.GetShape("Rectangle");
                shape.Draw(e.Graphics, i + 10, i + 10, i + 100, i + 100);
            }
        }
    }
}
