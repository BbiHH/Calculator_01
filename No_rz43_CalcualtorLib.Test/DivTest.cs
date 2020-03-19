using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using No_rz43_CalcualtorLib.Calculators;

namespace No_rz43_CalcualtorLib.Test
{
    [TestClass]
    public class DivTest
    {
        [TestMethod]
        public void DivTest_FourAndTwo_ReturnTwo()
        {
            //arrange
            Div div = new Div();
            var expected = 2;

            //action
            var actual = div.Calcualtor(4, 2);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}