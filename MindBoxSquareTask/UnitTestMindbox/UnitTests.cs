using System;
using Xunit;
using System.Linq;
using MindBoxSquareTask;
using MindBoxSquareTask.Entities;
using Xunit.Sdk;

namespace UnitTestMindbox
{
    public class UnitTests
    {
        private readonly Point[] points;
        private readonly Point[] pointsTriangle;
        public UnitTests()
        {
            points = new Point[] { new Point(0, 0), new Point(0, 1), new Point(1, 1), new Point(1, 0) };
            pointsTriangle = points.Where(p => p.X + p.Y < 2).Select(x => x).ToArray();
        }
        [Fact]
        public void TriangleSquareSimple()
        {
            Triangle t = new Triangle(pointsTriangle);
            Assert.Equal(0.5, t.Square());
        }
        [Fact]
        public void FigureSquareSimple()
        {
            Figure f = new Figure(points);
            Assert.Equal(1, f.Square());
        }
        [Fact]
        public void CircleSquareSimple()
        {

            Circle c;
            Exception exc = null;
            try
            {
                c = new Circle(points);
            }
            catch (ArgumentException e)
            {
                exc = e;
            }
            Assert.NotNull(exc);
            Point centr = new Point(2, 2);
            c = new Circle(centr, 2);
            Assert.Equal(Math.PI * 4, c.Square());
        }
    }
}
