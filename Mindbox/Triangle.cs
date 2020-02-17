using System;

namespace Mindbox
{
    public class Triangle : Figure
    {
        public double Perimeter => ASide + BSide + CSide;
        private double HalfPerimeter => Perimeter / 2;
        private double ASide = 0;
        private double BSide = 0;
        private double CSide = 0;
        public Triangle(double ASide, double BSide, double CSide)
        {
            this.ASide = ASide;
            this.BSide = BSide;
            this.CSide = CSide;
        }
        public override double Area() => Math.Sqrt(HalfPerimeter * (HalfPerimeter - ASide) * (HalfPerimeter - BSide) * (HalfPerimeter - CSide));
        public bool IsRightTriangle => Math.Pow(ASide, 2) + Math.Pow(BSide, 2) == Math.Pow(CSide, 2) ||
        Math.Pow(ASide, 2) + Math.Pow(CSide, 2) == Math.Pow(BSide, 2) ||
        Math.Pow(CSide, 2) + Math.Pow(BSide, 2) == Math.Pow(ASide, 2);
    }

}
