using System.Drawing;

namespace GB_Arch_Patterns_HW05_Brizhak_01
{
    /// <summary>
    /// Интерфейс для отрисовки фигур
    /// </summary>
    public interface IShape
    {
        void Draw(Graphics g, int x, int y, int width, int height);
    }
}
