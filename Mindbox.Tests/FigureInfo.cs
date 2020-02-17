using System;
using Xunit;

namespace Mindbox.Tests
{
    public class InfoTest
    {

        [Fact]
        public void AreaTriangle_ReturnTrue()
        {
            Assert.Equal(FigureInfo.Square(new Triangle(3, 4, 5)), 6);
        }

        [Fact]
        public void AreaCircle_ReturnTrue()
        {
            Assert.Equal(Math.Round(FigureInfo.Square(new Circle(3)), 2), 28.27);
        }

    }
}
