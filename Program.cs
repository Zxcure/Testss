using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathClass;

namespace Lib13
{
     internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Методы геометрии");
            Console.WriteLine("1)Площадь треугольника "+ GeometryClass.STriangle(4, 5).ToString());
            Console.WriteLine("2)Площадь прямоугольного треугольника " + GeometryClass.SPTriangle(5, 5).ToString());
            Console.WriteLine("3)Площадь прямоугольника " + GeometryClass.Srectangle(5, 5).ToString());
            Console.WriteLine("4)Площадь окружности  " + GeometryClass.Scircle(5).ToString());
            Console.WriteLine("5)Площадь трапеции  " + GeometryClass.Strapezoid(5,2,3).ToString());
            Console.WriteLine("Методы тригонометрии");
            Console.WriteLine("1)SinA " + TrigonometryClass.SinA(20, 40).ToString());
            Console.WriteLine("2)CosA " + TrigonometryClass.CosA(30, 40).ToString());
            Console.WriteLine("3)TgA " + TrigonometryClass.TgA(20, 30).ToString());
            Console.WriteLine("4)CTgA " + TrigonometryClass.CTgA(20, 30).ToString());



            Console.ReadKey();
        }
    }
}
