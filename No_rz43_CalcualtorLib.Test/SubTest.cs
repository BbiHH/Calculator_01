using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using No_rz43_CalcualtorLib.Calculators;

namespace No_rz43_CalcualtorLib.Test
{
    [TestClass]
    public class SubTest
    {
        [TestMethod]
        public void SubTest_FourAndFour_ReturnZero()
        {
            //arrange
            Sub sub = new Sub();
            var expected = 0;

            //action
            var actual = sub.Calcualtor(4, 4);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}