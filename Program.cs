// The Magic Cannon

int length = 100;
for (int i = 1; i <= length; i++)
{
  if (i % 3 == 0 && i % 5 == 0)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Combo Blast ({i})");
  }
  else if (i % 3 == 0)
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Fire ({i})");
  }
  else if (i % 5 == 0)
  {
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Electric ({i})");
  }
  else
  {
    Console.ResetColor();
    Console.WriteLine($"Normal ({i})");
  }
}
