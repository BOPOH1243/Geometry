using Geometry;
using System;
using NUnit.Framework;
using NUnit.Framework.Internal;
namespace Tests
{
    [TestFixture]
    public class GeometryTests
    {
        [TestCase(3, 4, 5, ExpectedResult = 6)]
        [TestCase(6, 8, 10, ExpectedResult = 24)]
        [TestCase(1, 1, 2, ExpectedResult = 0)]
        public double TriangleSquareTest(double A, double B, double C)
        {
            var triangle = new Geometry.Triangle(A, B, C);
            return triangle.GetSquare();
        }

        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        public void ExceptionTest(double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
        }

        [TestCase(3, 4, 5)]
        [TestCase(5, 12, 13)]
        [TestCase(8, 15, 17)]
        [TestCase(7, 24, 25)]
        [TestCase(20, 21, 29)]
        [TestCase(12, 35, 37)]
        [TestCase(9, 40, 41)]
        [TestCase(28, 45, 53)]
        [TestCase(11, 60, 61)]
        public void RightTriangleTest(double a, double b, double c)
        {
            Assert.AreEqual(new Triangle(a, b, c).isTriangleRight, true);
        }

        [TestCase(4, 4, 5)]
        [TestCase(6, 12, 13)]
        [TestCase(9, 15, 17)]
        [TestCase(8, 24, 25)]
        [TestCase(21, 21, 29)]
        [TestCase(13, 35, 37)]
        [TestCase(10, 40, 41)]
        [TestCase(29, 45, 53)]
        [TestCase(12, 60, 61)]
        public void notRightTriangleTest(double a, double b, double c)
        {
            Assert.AreEqual(new Triangle(a, b, c).isTriangleRight, false);
        }
        [Test]
        public void CircleExceptionTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(-1));
        }
        [Test]
        public void CircleSquareTest()
        {
            var circle = new Circle(1);
            Assert.AreEqual(circle.GetSquare(), Math.PI);
        }
    }
}
