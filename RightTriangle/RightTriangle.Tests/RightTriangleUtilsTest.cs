using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RightTriangle.Tests
{
    [TestClass]
    public class RightTriangleUtilsTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestPositiveLengthA()
        {
            RightTriangleUtils.CalculateSquare(-1, 2, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestPositiveLengthB()
        {
            RightTriangleUtils.CalculateSquare(1, -2, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestPositiveLengthC()
        {
            RightTriangleUtils.CalculateSquare(1, 2, -3);
        }
    }
}
