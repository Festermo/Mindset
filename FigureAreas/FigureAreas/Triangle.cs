namespace FigureAreas;

public class Triangle : IFigure
{
    private double _sideA;
    private double _sideB;
    private double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
        SwapSides();
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("Triangle side can't be zero or negative");
        }
        if (_sideA >= _sideB + _sideC)
        {
            throw new ArgumentException("One side of triangle can't be bigger than sum of another two");
        }
    }

    public bool IsRight()
    {
        return (_sideA * _sideA - _sideB * _sideB - _sideC * _sideC == 0); //math.pow is slow
    }

    public double GetArea()
    {
        double halfPerimeter = (_sideA + _sideB + _sideC) / 2d;
        double area = Math.Sqrt(halfPerimeter *
        (halfPerimeter - _sideA) *
        (halfPerimeter - _sideB) *
        (halfPerimeter - _sideC));
        return (area);
    }
    
    private void SwapSides()  // sideA is hypotenuse to simplify
    {
        if (_sideB > _sideA && _sideB > _sideC)
        {
            (_sideA, _sideB) = (_sideB, _sideA);
        }
        else if (_sideC > _sideA && _sideC > _sideB)
        {
            (_sideA, _sideC) = (_sideC, _sideA);
        }
    }
}