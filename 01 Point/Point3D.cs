namespace _01_Point;
public struct Point3D
{
    // Konstant fält
    private static readonly Point3D _center = new Point3D(0, 0, 0);

    // Konstruktor
    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    // Egenskaper
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    // Property för origo:
    public static Point3D Center
    {
        get { return _center; }
    }

    // Override metod
    public override string ToString()
    {
        return string.Format("{0}, {1}, {2}", X, Y, Z);
    }
}
