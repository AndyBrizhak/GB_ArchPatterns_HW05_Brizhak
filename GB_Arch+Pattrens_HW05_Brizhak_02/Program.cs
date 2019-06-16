using System;

// ДЗ к уроку 5 по курсу Архитектуры и шаблоны проектирования Брижак Андрей
//2. Реализовать «заместителя» при работе с классом Math, ограничив его четырьмя функциями:
//+, -, *, / .


namespace GB_Arch_Pattrens_HW05_Brizhak_02
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyMath proxyMath = new ProxyMath();
            Math myMath =new Math();

            Console.WriteLine( proxyMath.Add(3, 7));
            Console.WriteLine( proxyMath.Sub(3, 7));
            Console.WriteLine( proxyMath.Mul(3, 7));
            Console.WriteLine( proxyMath.Div(3, 7));
            Console.WriteLine(myMath.MedTwoNum(3,7));
            Console.ReadKey();

        }
    }
}
