using System;
using Xunit;

namespace Mindbox.Tests
{
    public class CircleTest
    {
       
        [Fact]
        public void Area_ReturnTrue()
        {
            Circle Circle = new Circle(3);

            Assert.Equal(Math.Round(Circle.Area(),2),28.27);
        }
        [Fact]
        public void Area_ReturnFalse()
        {
            Circle Circle = new Circle(3);
             Assert.NotEqual(Circle.Area(),7);
        }
    }
}
