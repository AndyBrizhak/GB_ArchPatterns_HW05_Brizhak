using System.Collections.Generic;

namespace GB_Arch_Patterns_HW05_Brizhak_01
{
    public class FactoryShapes
    {
        /// <summary>
        /// Словарь типов фигур
        /// </summary>
        static Dictionary<string, IShape> _shapeType = new Dictionary<string, IShape>();

        /// <summary>
        /// Метод создания и/или получения типов фигур в словаре _shapeType по наименованию,
        /// если тип фигуры еще не создан , то он этот тип создается как новый экземпляр своего класса,
        /// если такой тип уже есть в словаре, то передается уже существующий экземпляр.
        /// Если ни один из типов не совпадает по входящему наименованию, то возвращается null.
        /// </summary>
        /// <param name="nameType">Наименование фигуры</param>
        /// <returns></returns>
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
