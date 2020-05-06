using MindBoxSquareTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MindBoxSquareTask.Entities
{
    public class Figure : IFigure
    {

        /// <summary>
        /// Строим фигуру по n точкам в правильном порядке обхода
        /// </summary>
        /// <param name="points"></param>
        public Figure(Point[] points)
        {
            Points = points;
            if (Points != null)
                Demision = points.Length;
            else
                Demision = 0;
        }

        public Point[] Points { get; }

        public int Demision { get; }

        /// <summary>
        /// Применяем хитрую формулу для вычисления площади многоугольника
        /// </summary>
        /// <returns></returns>
        public virtual double Square()
        {
            double square = 0;
            for (int i = 0; i < Demision; ++i)
                square += Points[i] * Points[(i + 1) % Demision];
            return Math.Abs(square / 2);
        }

    }
}
