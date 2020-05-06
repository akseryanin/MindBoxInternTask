using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MindBoxSquareTask.Entities
{
    public class Triangle : Figure
    {
        private double[] distances;
        public Triangle(Point[] points) : base(points)
        {
            if (Demision != 3)
                throw new ArgumentException($"Треугольник должен состоять из трех точек, а передано {Demision} точек");
        }
        public Triangle(double a, double b, double c) : base(null)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Переданные стороны не соответсвуют неравенству треугольника");
            distances = new double[] { a, b, c };
        }
        public override double Square()
        {
            if (Points == null && distances.Length == 3)
            {
                double p = distances.Sum() / 2;
                return Math.Sqrt(p * distances.Aggregate((ans, x) => ans += p - x));
            }
            return base.Square();
        }
    }
}
