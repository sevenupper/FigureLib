using System;

namespace Mindbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Triangle(3, 4, 5).Area());
            Console.WriteLine(Math.Round(new Circle(3).Area(), 2));
            Console.WriteLine(FigureInfo.Square(new Triangle(3, 4, 5)));
            Console.WriteLine(new Triangle(3, 5, 4).IsRightTriangle);

        }
    }

}
