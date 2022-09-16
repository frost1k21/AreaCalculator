using AreaCalculator.Logic.Abstractions;

namespace AreaCalculator.Logic.Shapes
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; }

        public double CalaulateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
