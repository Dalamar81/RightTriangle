using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightTriangle
{
    public static class RightTriangleUtils
    {
        /// <summary>
        /// Вычисляет площадь прямоугольного треугольника
        /// </summary>
        /// <param name="a">Длина стороны a</param>
        /// <param name="b">Длина стороны b</param>
        /// <param name="c">Длина стороны c</param>
        public static double CalculateSquare(double a, double b, double c)
        {
            if (a <= 0)
                throw new ArgumentOutOfRangeException("a");
            if (b <= 0)
                throw new ArgumentOutOfRangeException("b");
            if (c <= 0)
                throw new ArgumentOutOfRangeException("c");

            // сортируем параметры
            double tmp;
            if (a > b) { tmp = a; a = b; b = tmp; }
            if (b > c) { tmp = b; b = c; c = tmp; }
            if (a > b) { tmp = a; a = b; b = tmp; }
            // теперь в a и b - катеты, в c - гипотенуза

            // проверяем, что треугольник - прямоугольный; но ограничим точность для избежания машинного нуля
            if (Math.Abs(c * c - a * a - b * b) > 0.0000000000001)
                throw new ArgumentException("Переданные стороны не являются сторонами прямоугольного треугольника");

            return 0.5 * a * b;
        }
    }
}
