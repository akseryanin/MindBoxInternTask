using System;
using System.Linq;
using MindBoxSquareTask;
using MindBoxSquareTask.Entities;
using Xunit;

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
            Triangle t1 = new Triangle(1, 1, Math.Sqrt(2));
            Assert.Equal(0.5, t.Square(), 2);
            Assert.Equal(0.5, t1.Square(), 2);
        }
        [Fact]
        public void FigureSquareSimple()
        {
            Figure f = new Figure(points);
            Assert.Equal(1, f.Square(), 2);
        }
        [Fact]
        public void CircleSquareSimple()
        {
            Point centr = new Point(2, 2);
            Circle c = new Circle(centr, 2);
            Assert.Equal(Math.PI * 4, c.Square(), 2);
        }
        [Fact]
        public void DegenerateFigureOneLineSquare()
        {
            Point a = new Point(0, 0);
            Point b = new Point(0, 10);
            Figure f1 = new Figure(new Point[] { a });
            Figure f2 = new Figure(new Point[] { a, b });
            Assert.Equal(0, f1.Square(), 2);
            Assert.Equal(0, f2.Square(), 2);
        }
        [Fact]
        public void IsRectangle()
        {
            Triangle t = new Triangle(pointsTriangle);
            Triangle t1 = new Triangle(1, 1, Math.Sqrt(3));
            Assert.True(t.IsRegtangle);
            Assert.False(t1.IsRegtangle);
        }
    }
}
