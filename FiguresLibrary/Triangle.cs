using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary.Base;

namespace FigureLibrary.Figures
{

    public class Triangle
    {
        public readonly Side SideOne;
        public readonly Side SideTwo;
        public readonly Side SideThree;
        public readonly double Square;

        public Triangle(Side sideOne, Side sideTwo)
        {
            SideOne = sideOne;

            if (ValidateSideTwo(sideOne, sideTwo))
                SideTwo = sideTwo;

            SideThree = new Side(sideTwo.End.XCoordinate, sideTwo.End.YCoordinate, sideOne.Start.XCoordinate, sideOne.Start.YCoordinate);

            if (CalculateArea() >= 0)
                Square = CalculateArea();
            else
                throw new ArgumentException("Площадь не может быть меньше или равной 0");
        }

        public bool ValidateSideTwo(Side sideA, Side sideB)
        {
            if (sideA.End.XCoordinate == sideB.Start.XCoordinate && sideA.End.YCoordinate == sideB.Start.YCoordinate)
                return true;
            else
                throw new ArgumentException("Треугольник должен быть замкнутым");
        }

        public double CalculateArea()
        {
            double halfPerimetr = (SideOne.Lenght + SideTwo.Lenght + SideThree.Lenght) / 2;

            return Math.Sqrt(halfPerimetr * (halfPerimetr - SideOne.Lenght) * (halfPerimetr - SideTwo.Lenght) * (halfPerimetr - SideThree.Lenght));
        }
    }
}
