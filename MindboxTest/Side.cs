using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTest.Base
{
    public class Side
    {
        public readonly Apex Start;
        public readonly Apex End;
        public readonly double Lenght;

        public Side(double apexStarX, double apexStartY, double apexEndX, double apexEndY)
        {
            Start = new Apex(apexStarX, apexStartY);
            End = new Apex(apexEndX, apexEndY);

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
