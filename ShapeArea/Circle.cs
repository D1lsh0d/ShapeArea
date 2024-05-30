namespace ShapeArea
{
    public class Circle : IShape
    {
        public double Radius { get; }
        public Circle(double radius) {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть больше 0");

            Radius = radius;
        }

        public double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
