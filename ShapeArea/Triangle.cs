namespace ShapeArea
{
    public class Triangle : IShape
    {
        public int SideA { get; }
        public int SideB { get; }
        public int SideC { get; }
        public Triangle(int a, int b, int c) {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Стороны должны быть больше 0");
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Стороны не формируют треугольник");

            SideA = a; 
            SideB = b; 
            SideC = c;
        }

        public double CalculateArea()
        {
            var p = ( SideA + SideB + SideC ) / 2;  
            return Math.Sqrt( p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool IsRightAngled()
        {
            int[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);  // сортируем массив для того чтобы найти самую длинную сторону - возможную гипотенузу
            // проверяем является ли треугольник прямоугольным по теореме Пифагора
            return Math.Pow(sides[2], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2);
        }
    }
}
