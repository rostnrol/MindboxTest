using System;
using NUnit.Framework;
using FigureLibrary.Base;
using FigureLibrary.Figures;

namespace UnitTest
{
    [TestFixture]
    public class UnknownFigureTest
    {
        [Test]
        public void IsAreaCountCorrect()
        {
            UnknownFigure polygon = new UnknownFigure(
                new Vector2D(10, 10),
                new Vector2D(60, 10),
                new Vector2D(100, 60),
                new Vector2D(100, 10));

            Assert.AreEqual(1000, polygon.Square);
        }
    }
}
