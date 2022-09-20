using System;
using NUnit.Framework;
using MindboxTest.Base;
using MindboxTest.Figures;

namespace MindboxTest.UnitTest
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void IsTriangleShapeClosed()
        {
            Side sideOne = new Side(0, 2, 3, 5);
            Side sideTwo = new Side(3, 5, 12, 16);
            Triangle triangle = new Triangle(sideOne, sideTwo);

            Assert.AreEqual(true, triangle.ValidateSideTwo(sideOne, sideTwo));
        }

        [Test]
        public void IsAngleRight()
        {
            Side sideOne = new Side(1, 1, 3, 3);
            Side sideTwo = new Side(3, 3, 9, 9);

            Assert.Throws<ArgumentException>(() => new Triangle(sideOne, sideTwo));
        }

        [Test]
        public void IsAreaCountCorrect()
        {
            Side sideOne = new Side(0, 0, 0, 4);
            Side sideTwo = new Side(0, 4, 3, 0);
            Triangle triangle = new Triangle(sideOne, sideTwo);

            Assert.AreEqual(6, triangle.Square);
        }
    }
}
