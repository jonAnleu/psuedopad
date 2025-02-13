// The Color

Color random = new Color( 2, 5, 4);
Color set = Color.Blue;

Console.WriteLine($"{random.R}, {random.G}, {random.B}");
Console.WriteLine($"{set.R} {set.G} {set.B}");

class Color
{
  public int R { get;}
  public int G { get;}
  public int B { get; }

  public Color(int red, int green, int blue)
  {
    R = red;
    G= green;
    B = blue;
  }
  public static Color White { get;} = new Color(255, 255, 255);
  public static Color Black { get;} = new Color(0,0,0);
  public static Color Red { get;} = new Color(255, 0, 0);
  public static Color Orange { get;} = new Color(255, 165, 0);
  public static Color Yellow { get;} = new Color(255, 255, 0);
  public static Color Green { get;} = new Color(0, 128, 0);
  public static Color Blue { get;} = new Color(0,0, 255);
  public static Color Purple { get;} = new Color(128, 0, 128);

}