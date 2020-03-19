using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using No_rz43_CalcualtorLib.Calculators;

namespace No_rz43_CalcualtorLib.Test
{
    [TestClass]
    public class MulTest
    {
        [TestMethod]
        public void MulTest_TwoAndFour_ReturnEight()
        {
            //arrange
            Mul mul = new Mul();
            var expected = 8;

            //action
            var actual = mul.Calcualtor(2, 4);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}