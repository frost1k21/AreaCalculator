using AreaCalculator.Logic;
using AreaCalculator.Logic.Abstractions;
using AreaCalculator.Logic.Shapes;

namespace AreaCalculator.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [ClassData(typeof(CalculatorTestsData))]
        public void CalculateArea_Should_ReturnsRightResult(IShape shape, double expectedArea)
        {
            Calculator calculator = new();
            var area = calculator.CalculateArea(shape);
            Assert.Equal(expectedArea, area, 4);
        }
    }

    public class CalculatorTestsData : TheoryData<IShape, double>
    {
        public CalculatorTestsData()
        {
            Add(new Triangle(5, 7, 9), 17.4123);
            Add(new Circle(3), 28.2743);
            Add(new Rectangle(2, 2), 4);
        }
    }
}
