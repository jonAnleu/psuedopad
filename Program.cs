// The Card

Color[] colors = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Yellow };
Rank[] ranks= new Rank[] { Rank.One, Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six, Rank.Seven, Rank.Eight, Rank.Nine, Rank.Ten, Rank.DollarSign, Rank.Percent, Rank.Caret, Rank.Ampersand };

foreach (Color color in colors)
{
    foreach (Rank rank in ranks)
    {
        Card card = new Card(rank, color);
        Console.WriteLine($"The {card.Color} {card.Rank}");
    }
}
class Card
{
  public Rank Rank { get; set; }
  public Color Color { get; set; }

  public Card(Rank rank, Color color)
  {
    Rank = rank;
    Color = color;
  }
  public bool IsSymbol => Rank == Rank.Ampersand || Rank == Rank.Caret || Rank == Rank.DollarSign || Rank == Rank.Percent;
  public bool IsNumber => !IsSymbol;
}

enum Color {Red, Green, Blue, Yellow}
enum Rank { One , Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, Ampersand}