using AreaCalculator.Logic.Abstractions;

namespace AreaCalculator.Logic.Shapes
{
    public class Triangle : IShape
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public bool IsRightTriangle => (SideA * SideA == SideB * SideB + SideC * SideC)
            || (SideB * SideB == SideA * SideA + SideC * SideC)
            || (SideC * SideC == SideA * SideA + SideB * SideB);
        public double CalaulateArea()
        {
            var semiPerimetr = (SideA + SideB + SideC) / 2.0;
            return Math.Sqrt(semiPerimetr * (semiPerimetr - SideA) * (semiPerimetr - SideB) * (semiPerimetr - SideC));
        }
    }
}
