using AreaCalculator.Logic.Abstractions;

namespace AreaCalculator.Logic.Shapes
{
    public class Rectangle : IShape
    {
        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public double SideA { get; }
        public double SideB { get; }

        public double CalaulateArea()
        {
            return SideA * SideB;
        }
    }
}
