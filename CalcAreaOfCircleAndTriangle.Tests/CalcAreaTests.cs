using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalcAreaOfCircleAndTriangle.Tests
{
    [TestClass]
    public class CalcAreaTests
    {
        /// <summary>
        /// Тест корректного значения площади круга
        /// </summary>
        [TestMethod]
        public void CorrectCircleAreaTest()
        {
            // Arrange
            var circle = new Circle(5);

            // Act
            var circleArea = circle.Area;

            // Assert
            Assert.AreEqual(78.53981633974483, circleArea);
        }

        /// <summary>
        /// Тест площади круга при отрицательном радиусе
        /// </summary>
        [TestMethod]
        public void CircleAreaWithNegativeRadiusTest()
        {
            Assert.ThrowsException<Exception>(() => new Circle(-5));
        }

        /// <summary>
        /// Тест площади круга при нулевом радиусе
        /// </summary>
        [TestMethod]
        public void CircleAreaWithZeroRadiusTest()
        {
            // Arrange
            var circle = new Circle(0);

            // Act
            var circleArea = circle.Area;

            // Assert
            Assert.AreEqual(0, circleArea);
        }

        /// <summary>
        /// Тест вычисления площади треугольника
        /// </summary>
        [TestMethod]
        public void CirrectTriangleAreaTest()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var triangleArea = triangle.Area;

            // Assert
            Assert.AreEqual(6, triangleArea);
        }

        /// <summary>
        /// Тест треугольника с отрицательными сторонами
        /// </summary>
        [TestMethod]
        public void NegativeSidesOfTriangleTest()
        {
            Assert.ThrowsException<Exception>(() => new Triangle(-3, 4, 5));
            Assert.ThrowsException<Exception>(() => new Triangle(3, -4, 5));
            Assert.ThrowsException<Exception>(() => new Triangle(3, 4, -5));
            Assert.ThrowsException<Exception>(() => new Triangle(-3, -4, -5));
        }

        /// <summary>
        /// Тест треугольника со сторонами равными 0
        /// </summary>
        [TestMethod]
        public void ZeroSidesOfTriangleTest()
        {
            Assert.ThrowsException<Exception>(() => new Triangle(0, 4, 5));
            Assert.ThrowsException<Exception>(() => new Triangle(3, 0, 5));
            Assert.ThrowsException<Exception>(() => new Triangle(3, 4, 0));
            Assert.ThrowsException<Exception>(() => new Triangle(0, 0, 0));
        }

        /// <summary>
        /// Тест на несуществующий треугольник
        /// </summary>
        [TestMethod]
        public void TriangleExistsTest()
        {
            Assert.ThrowsException<Exception>(() => new Triangle(1, 3, 5));
        }

        /// <summary>
        /// Тест, что треугольник прямоугольный
        /// </summary>
        [TestMethod]
        public void RightTriangleTest()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.AreEqual(true, isRightTriangle);
        }

        /// <summary>
        /// Тест, что треугольник не прямоугольный
        /// </summary>
        [TestMethod]
        public void NotRightTriangleTest()
        {
            // Arrange
            var triangle = new Triangle(6, 4, 5);

            // Act
            var isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.AreEqual(false, isRightTriangle);
        }

        /// <summary>
        /// Тест изменения стороны треугольника на недопустимое значение
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception), "Сторона треугольника должна быть > 0!")]
        public void ChangeSideToInvalidValueTest()
        {
            var triangle = new Triangle(3, 4, 5);
            triangle.SideA = 0;
        }
    }
}
