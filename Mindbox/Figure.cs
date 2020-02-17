namespace Mindbox
{
    public abstract class Figure : IArea
    {
        public abstract double Area();
    }
    public class FigureInfo
    {
        public static double Square(Figure f) => f.Area();
    }

}
