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
            throw new NotImplementedException();
        }
    }
}
