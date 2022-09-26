using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Base
{
    public class Vector2D
    {
        public readonly double XCoordinate;
        public readonly double YCoordinate;

        public Vector2D(double xCoordinate, double yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }
    }
}
