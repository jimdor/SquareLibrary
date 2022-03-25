using System;

namespace SquareLibrary
{
    public class SquareMethods
    {
        public static double Triangle(double[] sides, out double square)
        {
            Array.Sort(sides);

            if ((sides[0] + sides[1] < sides[2]) || (sides[0] < 0) || (sides[1] < 0) || (sides[2] < 0))   // проверяем существует ли такой треугольник 
            {
                square = 0;                                     // если не существует, то его площадь 0
            }
            else
            {
                if (Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))  // проверяем на прямоугольность
                {
                    square = sides[0] * sides[1] * 0.5;
                }
                else
                {
                    var halfP = (sides[0] + sides[1] + sides[2]) * 0.5;                             // площадь по формуле Герона
                    square = Math.Sqrt(halfP * (halfP - sides[0]) * (halfP - sides[1]) * (halfP - sides[2]));
                }
            }
            return square;
        }
        public static double Circle(double radius, out double square)
        {
            if (radius < 0)
            {
                square = 0;
            }
            else
            {
                square = Math.PI * Math.Pow(radius, 2);
            }
            return square;
        }
    }
}

