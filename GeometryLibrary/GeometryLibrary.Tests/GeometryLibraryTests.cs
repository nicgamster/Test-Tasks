using NUnit.Framework;
using GeometryLibrary;

namespace GeometryLibrary.Tests
{
    [TestFixture]
    public class GeometryTests
    {
        [Test]
        public void CircleArea_CalculatedCorrectly()
        {
            double radius = 5;
            Circle circle = new Circle(radius);

            Assert.That(circle.CalculateArea(), Is.EqualTo(Math.PI * radius * radius).Within(0.0001));
        }

        [Test]
        public void TriangleArea_CalculatedCorrectly()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            Assert.That(triangle.CalculateArea(), Is.EqualTo(6).Within(0.0001));
        }

        [Test]
        public void RightAngleTriangle_CheckCorrectness()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            Assert.That(triangle.IsRightAngleTriangle(), Is.True);
        }
    }
}
