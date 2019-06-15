using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

    // ДЗ к уроку 5 по курсу Архитектуры и шаблоны проектирования Брижак Андрей
    //1. Реализовать шаблон «Приспособленец» при отображении на экране окружностей и
    //прямоугольников в приложении Windows Forms.

namespace GB_Arch_Patterns_HW05_Brizhak_01
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
