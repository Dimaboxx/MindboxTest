using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8_lib
{
    public static class MyExtensions
    {
        /// <summary>
        /// возвращает <see langword="true"/> если треугольник прямоугольный
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        public static bool IsRightTriangle(this Triangle triangle)
        {
           var sides = triangle.Sides.OrderBy(s => s).ToList();

           return (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)).Equals(Math.Pow(sides[2], 2));
        }
    }
}
