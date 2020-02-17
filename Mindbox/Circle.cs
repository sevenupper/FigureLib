using System;

namespace Mindbox
{
    public class Circle : Figure
    {
        private double radius = 0;
        public Circle(double Radius) => this.radius = Radius;
        public override double Area() => Math.PI * Math.Pow(radius, 2);
    }

}
