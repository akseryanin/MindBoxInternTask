using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MindBoxSquareTask.Entities
{
    public class Triangle : Figure
    {
        private double[] distances;
        /// <summary>
        /// Будем строить треугольник по трем точкам
        /// </summary>
        /// <param name="points"></param>
        public Triangle(Point[] points) : base(points)
        {
            if (Demision != 3)
                throw new ArgumentException($"Треугольник должен состоять из трех точек, а передано {Demision} точек");
        }
        /// <summary>
        /// Строим треугольник по трем сторонам
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle(double a, double b, double c) : base(null)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Переданные стороны не соответсвуют неравенству треугольника");
            distances = new double[] { a, b, c };
        }
        /// <summary>
        /// Вычисляем площадь треугольника, если он построен по трем сторонам применяем другую формулу
        /// </summary>
        /// <returns></returns>
        public override double Square()
        {
            if (Points == null && distances != null)
            {
                double p = distances.Sum() / 2;
                return Math.Sqrt(p * (p - distances[0]) * (p - distances[1]) * (p - distances[2]) );
            }
            return base.Square();
        }
    }
}
