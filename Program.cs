//Vin Fletcher's Arrows (Classes)
using System.ComponentModel.DataAnnotations;

Arrow arrow = GetArrow();
Console.WriteLine($"The arrow you ordered will cost {arrow.GetCost()} gold");


Arrow GetArrow()
{
  Arrowhead arrowhead = GetArrowheadType();
  Fletching fletching = GetFletchingType();
  double length = GetLength();
  return new Arrow(arrowhead, fletching, length);
}

Arrowhead GetArrowheadType()
{
  Console.Write("Choose and arrowhead (Steel, Wood, Obsidian): ");
  string input = Console.ReadLine().ToLower();
  return input switch
  {
    "steel" => Arrowhead.Steel,
    "wood" => Arrowhead.Wood,
    "obsidian" => Arrowhead.Obsidian
  };
}

Fletching GetFletchingType()
{
  Console.Write("Choose a fletching type(Plastic, Turkey Feathers, Goose Feathers): ");
  string input = Console.ReadLine().ToLower();
  return input switch 
  {
    "plastic" => Fletching.Plastic,
    "turkey feathers" => Fletching.TurkeyFeathers,
    "goose feathers" => Fletching.GooseFeathers
  };
}

double GetLength()
{
  double length = 0;
  while (length < 60 || length > 100)
  {
  Console.Write("Choose a length between (60 - 100): ");
  length = Convert.ToDouble(Console.ReadLine());
  } 
    return length;
}
class Arrow
{
  public Arrowhead _arrowhead;
  public Fletching _fletching;
  public double _length;

  public Arrow(Arrowhead arrowhead, Fletching fletching, double length)
  {
    _arrowhead = arrowhead;
    _fletching = fletching;
    _length = length;
  }

  public double GetCost()
  {
    double arrowheadCost = _arrowhead switch
    {
      Arrowhead.Steel => 10,
      Arrowhead.Wood => 3,
      Arrowhead.Obsidian => 5
    };
    double fletchingCost = _fletching switch
    {
      Fletching.Plastic => 10,
      Fletching.TurkeyFeathers => 5,
      Fletching.GooseFeathers => 3
    };
    double lengthCost = _length * .05;
    return arrowheadCost + fletchingCost + lengthCost;
  }



}
  public enum Arrowhead {Steel, Wood, Obsidian}
  public enum Fletching {Plastic, TurkeyFeathers, GooseFeathers}