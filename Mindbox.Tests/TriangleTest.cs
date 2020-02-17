using System;
using Xunit;

namespace Mindbox.Tests
{
    public class TriangleTest
    {

        [Fact]
        public void IsRightTriangle_ReturnTrue()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Assert.True(triangle.IsRightTriangle);
        }
        [Fact]
        public void IsRightTriangle_ReturnFalse()
        {
            Triangle triangle = new Triangle(3, 4, 6);
            Assert.False(triangle.IsRightTriangle);
        }
        [Fact]
        public void Area_ReturnTrue()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.Equal(triangle.Area(),6);
        }
        [Fact]
        public void Area_ReturnFalse()
        {
            Triangle triangle = new Triangle(3, 4, 6);
             Assert.NotEqual(triangle.Area(),7);
        }
    }
}
