using System;
using System.Collections.Generic;
using System.Text;

namespace MindBoxSquareTask.Interfaces
{
    interface IFigure
    {
        public int Demision { get; }//
        public Point[] Points { get; }
        public abstract double Square();

    }
}
