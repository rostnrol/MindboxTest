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
        public readonly Vector2D VectorOne;
        public readonly Vector2D VectorTwo;
        public readonly Vector2D VectorThree;

        public readonly Side SideOne;
        public readonly Side SideTwo;
        public readonly Side SideThree;
        public readonly double Square;

        public Triangle(Vector2D vectorOne, Vector2D vectorTwo, Vector2D vectorThree)
        {
            VectorOne = vectorOne;
            VectorTwo = vectorTwo;
            VectorThree = vectorThree;

            SideOne = new Side(vectorOne.XCoordinate, vectorOne.YCoordinate, vectorTwo.XCoordinate, vectorTwo.YCoordinate);
            SideTwo = new Side(vectorTwo.XCoordinate, vectorTwo.YCoordinate, vectorThree.XCoordinate, vectorThree.YCoordinate);
            SideThree = new Side(vectorThree.XCoordinate, vectorThree.YCoordinate, vectorOne.XCoordinate, vectorOne.YCoordinate);

            Square = CalculateArea();
        }

        public double CalculateArea()
        {
            double halfPerimetr = (SideOne.Lenght + SideTwo.Lenght + SideThree.Lenght) / 2;

            return Math.Sqrt(halfPerimetr * (halfPerimetr - SideOne.Lenght) * (halfPerimetr - SideTwo.Lenght) * (halfPerimetr - SideThree.Lenght));
        }
    }
}
