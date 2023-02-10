namespace FigureAreas;

public class Circle : IFigure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Circle radius can't be zero or negative");
        }
        _radius = radius;
    }

    public double GetArea()
    {
        double area = Math.PI * _radius * _radius; //math.pow is slow
        return area;
    }
}