using System;
using NUnit.Framework;
using MindboxTest.Base;
using MindboxTest.Figures;

namespace MindboxTest.UnitTest
{
    [TestFixture]
    public class UnknownFigureTest
    {
        [Test]
        public void IsAreaCountCorrect()
        {
            UnknownFigure polygon = new UnknownFigure(
                new Apex(10, 10),
                new Apex(60, 10),
                new Apex(100, 60),
                new Apex(100, 10));

            Assert.AreEqual(1000, polygon.Square);
        }
    }
}
