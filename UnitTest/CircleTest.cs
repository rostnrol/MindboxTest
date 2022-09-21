using System;
using NUnit.Framework;
using FigureLibrary.Base;
using FigureLibrary.Figures;

namespace UnitTest
{
    [TestFixture]
    public class CircleTest
    {
        [Test]
        public void IsAreaCountCorrect()
        {
            Side radius = new Side(-1, 0, 3, 0);
            Circle circle = new Circle(radius);

            Assert.AreEqual(50, Math.Round(circle.CalculateArea()));
        }
    }
}
