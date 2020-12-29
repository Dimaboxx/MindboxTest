using System;

namespace Q8_lib
{
    /// <summary>
    /// используется допущение что полученные фигуры корректны
    /// и длянна сторон больше нуля.
    /// </summary>
    public static class GeometryLib
    {
        public static double AreaofShapes(Figure figure)
        {
            if (figure.GetType() == typeof(Circle))
            {
                    return 2 * Math.PI * ((Circle)figure).Radius;
            }
            else if(figure.GetType() == typeof(Triangle))
            {
                Triangle triangle = figure as Triangle;
                double halfPerimeter = (triangle.Sides[0] + triangle.Sides[1] + triangle.Sides[2])/2;

                return Math.Sqrt(halfPerimeter * 
                                (halfPerimeter - triangle.Sides[0]) *
                                (halfPerimeter - triangle.Sides[1]) * 
                                (halfPerimeter - triangle.Sides[2]));
            }
            
                return 0;
        }
    }
}
