// BOSS BATTLE: Hunting the Manticore

using System.Globalization;

int manticoreRange = RandomNumGenerator();
int round = 1;
int cityHealth = 15;
int manticoreHealth = 10;
int roundDamage = 1;
bool gameOver = false;



Console.Clear();
Console.WriteLine("\nDefend Consolas from the Manticore");
Console.WriteLine("---------------------------------------------");
GameStatus();
CannonRange();



int RandomNumGenerator()
{
  Random random = new Random();
  return random.Next(0, 100);
}

void GameStatus()
{
string status = $"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {manticoreHealth}/10 ";
Console.WriteLine(status);
if (manticoreHealth == 0)
{
  Console.Clear();
  
  Console.WriteLine("\nThe Manticore has been destroyed! The city of Consolas has been saved!\n");
  Console.WriteLine("Game Over\n");
  gameOver = true;
} 
if (cityHealth == 0)
{
  Console.Clear();
  Console.WriteLine("\nGame Over the Manticore defeated Consolas\n");
  gameOver = true;
  
}
if (round % 5 == 0 && round % 3 == 0)
{
  roundDamage = 10;
  Console.WriteLine($"The cannon is expected to deal {roundDamage} damage this round.");
}else if(round % 3 == 0 || round % 5 == 0)
{
  roundDamage = 3;
  Console.WriteLine($"The cannon is expected to deal {roundDamage} damage this round.");
}
else
{

  Console.WriteLine($"The cannon is expected to deal {roundDamage} damage this round.");
}
}

void CannonRange()
{
  Console.Write("Enter you cannon range: ");
  int rangeChoice = Convert.ToInt32(Console.ReadLine());
  if (rangeChoice > manticoreRange)
  {
    Console.WriteLine("That round OVERSHOT the Manticore.");
  } else if(rangeChoice < manticoreRange)
  {
    Console.WriteLine("That round FELL SHORT of the Manticore");
  } else
  {
    Console.WriteLine("DIRECT HIT!");
  }
}