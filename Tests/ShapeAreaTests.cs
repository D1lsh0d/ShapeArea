using ShapeArea;
using System;


namespace Tests
{
    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void TestTriangleArea()
        {
            int sideA = 3;
            int sideB = 4;
            int sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double expectedArea = 6.0; 
            Assert.AreEqual(expectedArea, triangle.CalculateArea(), 1e-10);
        }

        [TestMethod]
        public void TestRightAngledTriangle()
        {
            int sideA = 3;
            int sideB = 4;
            int sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.IsTrue(triangle.IsRightAngled());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidTriangle()
        {
            int sideA = 1;
            int sideB = 1;
            int sideC = 10;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
        }

        [TestMethod]
        public void TestCircleArea()
        {
            double radius = 5.0;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;
            Assert.AreEqual(expectedArea, circle.CalculateArea(), 1e-10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))] public void TestInvalidCircle()
        {
            int radius = 0;
            Circle circle = new Circle(radius);
        }
        // Вычисление площади фигуры в compile-time
        [TestMethod]
        public void TestCalculateShapeArea()
        {
            IShape circle = new Circle(5.0);
            IShape triangle = new Triangle(3, 4, 5);

            double circleArea = ShapeAreaCalculator.CalculateShapeArea(circle);
            double expectedCircleArea = Math.PI * 5.0 * 5.0;
            Assert.AreEqual(expectedCircleArea, circleArea, 1e-10);

            double triangleArea = ShapeAreaCalculator.CalculateShapeArea(triangle);
            double expectedTriangleArea = 6.0; 
            Assert.AreEqual(expectedTriangleArea, triangleArea, 1e-10);
        }
    }
}