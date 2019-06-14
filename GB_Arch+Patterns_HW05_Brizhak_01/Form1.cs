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

        void Draw()
        {
            for (int i = 0; i < 4; i++)
            {
                IShape _shape = FactoryShapes.GetShape("Circle");
                //_shape.();
            }
        }
    }
}
