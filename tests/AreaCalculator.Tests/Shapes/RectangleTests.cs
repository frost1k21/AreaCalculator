using AreaCalculator.Logic.Shapes;

namespace AreaCalculator.Tests.Shapes
{
    public class RectangleTests
    {
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(1, 3, 3)]
        [InlineData(2, 2, 4)]
        public void CalculateAraea_Shuold_ReturnsRightResult(double sideA, double sideB, double expectedArea)
        {
            Rectangle rectangle = new(sideA, sideB);
            var area = rectangle.CalaulateArea();
            Assert.Equal(expectedArea, area);
        }
    }
}
