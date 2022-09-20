using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindboxTest.Base;

namespace MindboxTest.Figures
{
    public class Circle
    {
        public readonly Side Radius;
        public readonly double Square;

        public Circle(Side radius)
        {
            Radius = radius;
            Square = CalculateArea();
        }

        public double CalculateArea()
        {
            return Math.PI* Math.Pow(Radius.Lenght, 2);
        }
    }
}
