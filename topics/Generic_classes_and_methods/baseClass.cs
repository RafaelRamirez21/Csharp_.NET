public class Point{}
public class Point3D : Point
{
    public int Z { get; set; }
    
    public Point3D(int x, int y, int z) : base(x, y)
    {
        Z = z;
    }
}
// Point a = new(10, 20);
// Point b = new Point3D(10, 20, 30);