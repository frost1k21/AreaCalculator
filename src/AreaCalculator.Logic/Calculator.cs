using AreaCalculator.Logic.Abstractions;

namespace AreaCalculator.Logic
{
    public class Calculator : IAreaCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape.CalaulateArea();
        }
    }
}
