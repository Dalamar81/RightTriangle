using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RightTriangle.Tests
{
    [TestClass]
    public class RightTriangleUtilsTest
    {

        // Тесты проверки на положительность аргументов
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalculateSquare_PositiveLengthA()
        {
            RightTriangleUtils.CalculateSquare(-1, 2, 3);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalculateSquare_PositiveLengthA0()
        {
            RightTriangleUtils.CalculateSquare(0, 2, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalculateSquare_PositiveLengthB()
        {
            RightTriangleUtils.CalculateSquare(1, -2, 3);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalculateSquare_PositiveLengthB0()
        {
            RightTriangleUtils.CalculateSquare(1, 0, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalculateSquare_PositiveLengthC()
        {
            RightTriangleUtils.CalculateSquare(1, 2, -3);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalculateSquare_PositiveLengthC0()
        {
            RightTriangleUtils.CalculateSquare(1, 2, 0);
        }

        // Тест проверки, что треугольник - прямоугольный
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateSquare_IsRightTriangle1()
        {
            RightTriangleUtils.CalculateSquare(1, 2, 3); // не прямоугольный треугольник
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateSquare_IsRightTriangle2()
        {
            RightTriangleUtils.CalculateSquare(345, 12, 2342); // не прямоугольный треугольник
        }

        // Проверки правильности вычисления
        [TestMethod]
        public void CalculateSquare_CorrectCalc1()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double square = 6;
            double result = RightTriangleUtils.CalculateSquare(a, b, c);
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void CalculateSquare_CorrectCalc2()
        {
            double a = 15;
            double b = 8;
            double c = 17;
            double square = 60;
            double result = RightTriangleUtils.CalculateSquare(a, b, c);
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void CalculateSquare_CorrectCalc3()
        {
            double a = 9;
            double b = Math.Sqrt(106);
            double c = 5;
            double square = 22.5;
            double result = RightTriangleUtils.CalculateSquare(a, b, c);
            Assert.AreEqual(square, result);
        }
    }
}
