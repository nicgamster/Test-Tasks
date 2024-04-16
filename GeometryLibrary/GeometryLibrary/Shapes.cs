namespace GeometryLibrary
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом.", nameof(radius));
            }

            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }

    public class Triangle : IShape
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Стороны треугольника должны быть положительными числами.", nameof(side1));
            }

            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double CalculateArea()
        {
            // Формула Герона
            double s = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
        }

        public bool IsRightAngleTriangle()
        {
            // Теорема Пифагора
            double[] sides = { _side1, _side2, _side3 };
            Array.Sort(sides);
            return sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1];
        }
    }

    public class Rectangle : IShape
    {
        private readonly double _length;
        private readonly double _width;

        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }

        public double CalculateArea()
        {
            return _length * _width;
        }
    }
}
