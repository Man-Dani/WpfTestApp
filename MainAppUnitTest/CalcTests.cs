using Microsoft.VisualStudio.TestTools.UnitTesting;

using WpfTestApp;

namespace MainAppUnitTest
{
	[TestClass]
	public class CalcTests
	{
		[DataTestMethod]
		[DataRow(3, 2, 5)]
		public void TestsSummationOfTwoIntegers(int i1, int i2, int erg)
		{
			Assert.AreEqual(erg, Calc.Add(i1, i2));
		}

		[TestMethod]
		public void TestsSummationOfTwoIntegers2()
		{
			var sum = Calc.Add(2, 3);
			Assert.AreEqual(5, sum);
		}
	}
}