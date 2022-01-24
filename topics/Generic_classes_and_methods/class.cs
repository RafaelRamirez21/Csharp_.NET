public class Point
{
    public int X { get; }
    public int Y { get; }
    
    public Point(int x, int y) => (X, Y) = (x, y);
}
// var p1 = new Point(0, 0);
// var p2 = new Point(10, 20);