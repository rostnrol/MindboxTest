using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Base
{
    public class Side
    {
        public readonly Vector2D Start;
        public readonly Vector2D End;
        public readonly double Lenght;

        public Side(double vector2dStarX, double vector2dStartY, double vector2dEndX, double vector2dEndY)
        {
            Start = new Vector2D(vector2dStarX, vector2dStartY);
            End = new Vector2D(vector2dEndX, vector2dEndY);

            if(ValidateSide())
            Lenght = CalculateLength();
        }

        public bool ValidateSide()
        {
            if (Start.XCoordinate == End.XCoordinate && Start.YCoordinate == End.YCoordinate)
                throw new ArgumentException("Длина отрезка не может быть равна 0");
            else
                return true;
        }

        public double CalculateLength()
        {
            return Math.Sqrt(Math.Pow(End.XCoordinate - Start.XCoordinate, 2) + Math.Pow(End.YCoordinate - Start.YCoordinate, 2));
        }
    }
}
