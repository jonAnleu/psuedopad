// Boss Battle THE POINT 

Point point = new(2, 3);
Point point1= new(-4, 0);
Point origin = new();

Console.WriteLine($"{origin.X} {origin.Y}");
Console.WriteLine($"{point.X}, {point.Y}");
Console.WriteLine($"{point1.X}, {point1.Y}");

class Point
{
  public int X { get; set; }
  public int Y { get; set; }

  public Point(int x, int y)
  {
    X = x;
    Y = y;
  }

  public Point()
  {
    X = 0;
    Y = 0;
  }
}