using System;

namespace MindBoxSquareTask
{
    public class Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x; Y = y;
        }

        /// <summary>
        /// Переопределим оператор умножения для точек как векторное произведение
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double operator * (Point a, Point b)
        {
            return a.X * b.Y - a.Y * b.X;
        }

        /// <summary>
        /// Расстояние между точками
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public double distance(Point b)
        {
            return Math.Sqrt(Math.Pow(X - b.X, 2) + Math.Pow(Y - b.Y, 2));
        }
    }
}
