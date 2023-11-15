using NUnit.Framework;
using Radius;

namespace Area.Tests;

[TestFixture]
public class FigureAreaTests
{
    [Test]
    public void CalculateCircleArea()
    {
        var circle = new Circle(7);
        Assert.AreEqual(Math.PI * 49, circle.CalculateArea(), 0.001);
    }

    [Test]
    public void CalculateTriangleArea()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.AreEqual(6, triangle.CalculateArea(), 0.001);
    }

    [Test]
    public void CheckRightTriangle()
    {
        var rightTriangle = new Triangle(3, 4, 5);
        Assert.IsTrue(rightTriangle.IsRightTriangle());

        var nonRightTriangle = new Triangle(2, 3, 4);
        Assert.IsFalse(nonRightTriangle.IsRightTriangle());
    }
}