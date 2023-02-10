using FigureAreas;

namespace FigureAreasTests;

public class CircleTests
{
    [TestCase(0)]
    [TestCase(-1)]
    public void TestWrongRadius(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }

    [TestCase(1)]
    [TestCase(5)]
    [TestCase(70)]
    [TestCase(55555)]
    public void TestCircleArea(double radius)
    {
        Circle circle = new Circle(radius);
        double area = circle.GetArea();
        double expectedArea = Math.Pow(radius, 2) * Math.PI;
        Assert.That(area, Is.EqualTo((expectedArea)));
    }
}