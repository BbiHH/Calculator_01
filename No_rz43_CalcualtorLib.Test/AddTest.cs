using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using No_rz43_CalcualtorLib.Calculators;

namespace No_rz43_CalcualtorLib.Test
{
	[TestClass]
	public class AddTest
	{
		[TestMethod]
		public void AddTest_TwoAndFour_ReturnSix()
		{
			//arrange
			Add add = new Add();
			var expected = 6;

			//action
			var actual = add.Calcualtor(2, 4);

			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}
