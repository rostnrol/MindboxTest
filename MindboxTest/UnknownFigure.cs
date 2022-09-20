using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindboxTest.Base;

namespace MindboxTest.Figures
{
    class UnknownFigure
    {
        private List<Apex> _dots;
        public readonly double Square;

        public UnknownFigure(params Apex[] dots)
        {
            _dots = dots.ToList();
            Square = CalculateArea();
        }

        public double CalculateArea()
        {
            double area = default(double);

            for (int i = 0; i < _dots.Count - 1; i++)
            {
                area += _dots[i].XCoordinate * _dots[i + 1].YCoordinate - _dots[i].YCoordinate * _dots[i + 1].XCoordinate;
            }

            area += _dots[_dots.Count - 1].XCoordinate * _dots[0].YCoordinate - _dots[_dots.Count - 1].YCoordinate * _dots[0].XCoordinate;

            return Math.Abs(area) / 2;
        }
    }
}
