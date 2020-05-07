using System;

namespace MindBoxSquareTask.Entities
{
    public class Circle : Figure
    {
        //
        public Point Center;
        public double Radius { get; }

        public Circle(Point centr, double r) : base(new Point[] { centr })
        {
            Radius = r;
            Center = centr;
        }
        /// <summary>
        /// Пплощадь круга
        /// </summary>
        /// <returns></returns>
        public override double Square()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
