using System;
using NUnit.Framework;
using FigureLibrary.Base;
using FigureLibrary.Figures;

namespace UnitTest
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void IsAreaCountCorrect()
        {
            Vector2D vectorOne = new Vector2D(0, 0);
            Vector2D vectorTwo = new Vector2D(0, 4);
            Vector2D vectorThree = new Vector2D(3, 0);

            Triangle triangle = new Triangle(vectorOne, vectorTwo, vectorThree);

            Assert.AreEqual(6, triangle.Square);
        }
    }
}
