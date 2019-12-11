using System;
using System.Collections.Generic;
using AreaCalculator.Models;
using AreaCalculator.Shapes;
using Xunit;

namespace UnitTestProject
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void TestCircleArea()
        {
            var radius = 5;
            var expected = Math.PI * Math.Pow(radius, 2);

            var circle = new Circle(radius);
            var actual = circle.CalculateArea();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTriangleArea()
        {
            var a = 3;
            var b = 4;
            var c = 5;

            var expected = 6;

            var triangle = new Triangle(a, b, c);
            var actual = triangle.CalculateArea();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestRandomShapeArea()
        {
            var points = new List<Point>
            {
                new Point(1, 1),
                new Point(2, 1),

                new Point(2, 2),
                new Point(4, 2)
            };

            var expected = 1 + 4;

            var randomShape = new RandomShape(points);
            var actual = randomShape.CalculateArea();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestStraightforwardTriangleCheck()
        {
            Assert.True(new Triangle(3, 4, 5).IsStraightforward());
            Assert.False(new Triangle(2, 4, 5).IsStraightforward());
        }
    }
}
