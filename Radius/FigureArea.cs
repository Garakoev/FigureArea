using Area.Interfaces;

namespace Radius;

public class Circle : IArea
{
    public readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}

public class Triangle : IArea
{
    public readonly double _sideA;
    public readonly double _sideB;
    public readonly double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public double CalculateArea()
    {
        if (!IsRightTriangle())
        {
            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }
        else
        {
            double[] sides = { _sideA, _sideB, _sideC };
            Array.Sort(sides);
            return (sides[0] * sides[1]) / 2;
        }
    }

    public bool IsRightTriangle()
    {
        double[] sides = { _sideA, _sideB, _sideC };
        Array.Sort(sides);
        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }
}