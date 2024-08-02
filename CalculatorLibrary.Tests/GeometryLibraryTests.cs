using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorLibrary.Tests
{
    public class GeometryLibraryTests
    {
        [Fact]
        public void CalculateCircleArea_ReturnsCorrectValue()
        {
            var circle = new Circle(5);
            double area = GeometryCalculator.CalculateArea(circle);
            Assert.Equal(Math.PI * 25, area);
        }

        [Fact]
        public void CalculateTriangleArea_ReturnsCorrectValue()
        {
            var triangle = new Triangle(3, 4, 5);
            double area = GeometryCalculator.CalculateArea(triangle);
            Assert.Equal(6, area);
        }

        [Fact]
        public void IsRightAngledTriangle_ValidatesCorrectly()
        {
            bool result = GeometryCalculator.IsRightAngledTriangle(3, 4, 5);
            Assert.True(result);
        }

        [Fact]
        public void IsTriangleValid_InvalidSides_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 10));
        }
    }
}
