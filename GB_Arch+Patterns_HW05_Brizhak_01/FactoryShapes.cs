using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_HW05_Brizhak_01
{
   public class FactoryShapes
    {
        static Dictionary<string, IShape> _shapeType = new Dictionary<string, IShape>();

        public static IShape GetShape(string nameType)
        {
            if (nameType=="Circle")
            {
                if (!_shapeType.ContainsKey("Circle"))
                {
                    _shapeType ["Circle"] = new Circle();
                }

                return _shapeType["Circle"];
            }

            if (nameType=="Rectangle")
            {
                if (!_shapeType.ContainsKey("Rectangle"))
                {
                    _shapeType["Rectangle"] = new Rectangle();
                }

                return _shapeType["Rectangle"];
            }

            return null;
        }


    }
}
