using AreaCalculator.Logic.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Tests.Shapes
{
    public class CircleTests
    {
        [Theory]
        [InlineData(2, 12.5664)]
        [InlineData(5, 78.5398)]
        [InlineData(3, 28.2743)]
        public void CalculateAraea_Shuold_ReturnsRightResult(double radius, double expectedArea)
        {
            Circle circle = new(radius);
            var area = circle.CalaulateArea();
            Assert.Equal(expectedArea, area, 4);
        }
    }
}
