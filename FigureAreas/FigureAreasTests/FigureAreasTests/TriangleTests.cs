namespace FigureAreasTests;
using FigureAreas;

public class TriangleTests
{
    [TestCase(0, 3, 3)]
    [TestCase(2, -1, 3)]
    [TestCase(5, 3, 0)]
    [TestCase(1, 2, 6)]
    public void TestWrongTriangle(double sideA, double sideB, double sideC)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }
    
    [TestCase(3, 4, 5, ExpectedResult = 6)]
    [TestCase(7, 24, 25, ExpectedResult = 84)]
    [TestCase(5, 12, 13, ExpectedResult = 30)]
    [TestCase(6, 8, 10, ExpectedResult = 24)]
    public double TestTriangleArea(double sideA, double sideB, double sideC)
    {
        Triangle triangle = new Triangle(sideA, sideB, sideC);
        double area = triangle.GetArea();
        return area;
    }

    [TestCase(3, 4, 5, ExpectedResult = true)]
    [TestCase(7, 24, 25, ExpectedResult = true)]
    [TestCase(5, 7, 10, ExpectedResult = false)]
    [TestCase(10, 13, 20, ExpectedResult = false)]
    public bool TestIfTriangleIsRight(double sideA, double sideB, double sideC)
    {
        Triangle triangle = new Triangle(sideA, sideB, sideC);
        bool isRight = triangle.IsRight();
        return isRight;
    }
}