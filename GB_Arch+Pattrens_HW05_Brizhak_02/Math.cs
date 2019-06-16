namespace GB_Arch_Pattrens_HW05_Brizhak_02
{
    /// <summary>
    /// Исходный класс Math
    /// </summary>
    class Math : IMath
    {
        /// <summary>
        /// Метод возвращает сумму чисел
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Add(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Метод возвращает разность чисел
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Div(int x, int y)
        {
            return x - y;
        }

        /// <summary>
        /// Метод возвращает результат умножения чисел
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Mul(int x, int y)
        {
            return x * y;
        }

        /// <summary>
        /// Метод возвращает результат деления чисел
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Sub(int x, int y)
        {
            return x / y;
        }

        /// <summary>
        /// Метод возвращает медиану двух чисел
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int MedTwoNum(int x, int y)
        {
            return (x+y)/2 ;
        }
    }
}
