using AreaCalculator.Logic.Shapes;

namespace AreaCalculator.Tests.Shapes
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(1, 2, 2, 0.9682)]
        [InlineData(4, 5, 2, 3.7997)]
        [InlineData(5, 7, 9, 17.4123)]
        public void CalculateAraea_Shuold_ReturnsRightResult(double sideA, double sideB, double sideC, double expectedArea)
        {
            Triangle triangle = new(sideA, sideB, sideC);
            var area = triangle.CalaulateArea();
            Assert.Equal(expectedArea, area, 4);
        }

        [Theory]
        [InlineData(1, 2, 2, false)]
        [InlineData(4, 5, 2, false)]
        [InlineData(7, 25, 24, true)]
        [InlineData(3, 5, 4, true)]
        public void IsRightTriangle_Should_ReturnsRightResult(double sideA, double sideB, double sideC, bool expectedIsRightTriangle)
        {
            Triangle triangle = new(sideA, sideB, sideC);
            var isRigthTriangle = triangle.IsRightTriangle;
            Assert.Equal(expectedIsRightTriangle, isRigthTriangle);
        }
    }
}
