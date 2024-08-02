using CalculatorLibrary;

public class Triangle : IShape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (!IsTriangleValid(sideA, sideB, sideC))
            throw new ArgumentException("A triangle with the given sides does not exist.");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double CalculateArea()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }
    public static bool IsRightAngledTriangle(double sideA, double sideB, double sideC)
    {
        double[] sides = { sideA, sideB, sideC };
        Array.Sort(sides);

        if (sides[0] <= 0 || sides[1] <= 0 || sides[2] <= 0)
            throw new ArgumentException("All sides must be positive numbers.");

        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }

    private static bool IsTriangleValid(double sideA, double sideB, double sideC)
    {
        if (!(sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA))
            throw new ArgumentException("Invalid triangle sides.");
        return true;
    }
}
