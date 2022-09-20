using MindboxTest.Base;
using NUnit.Framework;

namespace MindBoxTest.UnitTest
{
	[TestFixture]
	public class SideTest
	{
		[Test]
		public void SideCorrectLengthCalculate()
		{
			Side side = new Side(0, 0, -5, 0);

			Assert.AreEqual(5, side.Lenght);
		}
	}
}