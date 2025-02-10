// BOSS BATTLE: Hunting the Manticore

using System.Globalization;

int manticoreRange = RandomNumGenerator();
int round = 1;
int cityHealth = 15;
int manticoreHealth = 10;
int roundDamage = 1;
bool gameOver = false;

do{
Console.Clear();
Console.WriteLine("\nDefend Consolas from the Manticore");
Console.WriteLine("---------------------------------------------");
GameStatus();
if(!gameOver)
{
CannonRange();
round++;
cityHealth--;
}
}while(!gameOver);



int RandomNumGenerator()
{
  Random random = new Random();
  return random.Next(0, 100);
}

void GameStatus()
{
string status = $"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {manticoreHealth}/10 ";
Console.WriteLine(status);
if (manticoreHealth <= 0)
{
  Console.Clear();
  Console.WriteLine("\nThe Manticore has been destroyed! The city of Consolas has been saved!\n");
  gameOver = true;
} 
if (cityHealth == 0)
{
  Console.Clear();
  Console.WriteLine("\nThe Manticore defeated Consolas\n");
  gameOver = true;
  
}
if (round % 5 == 0 && round % 3 == 0)
{
  roundDamage = 10;
  Console.WriteLine($"\nThe cannon is expected to deal {roundDamage} damage this round.");
}else if(round % 3 == 0 || round % 5 == 0)
{
  roundDamage = 3;
  Console.WriteLine($"\nThe cannon is expected to deal {roundDamage} damage this round.");
}
else
{

  Console.WriteLine($"\nThe cannon is expected to deal {roundDamage} damage this round.");
}
}

void CannonRange()
{
  Console.Write("Enter you cannon range between 0-100: ");
  int rangeChoice = Convert.ToInt32(Console.ReadLine());
  if (rangeChoice > manticoreRange)
  {
    Console.WriteLine("That round OVERSHOT the Manticore.");
  } else if(rangeChoice < manticoreRange)
  {
    Console.WriteLine("\nThat round FELL SHORT of the Manticore");
  } else
  {
    manticoreHealth -= roundDamage;
    Console.WriteLine("DIRECT HIT!");
  }
  Console.WriteLine("\nPress any key to continue...");
  Console.ReadKey();
}

/* Claude code suggestion

class ManticoreGame
{
    private int manticoreRange;
    private int round;
    private int cityHealth;
    private int manticoreHealth;
    private int roundDamage;
    private bool gameOver;
    private readonly Random random;

    public ManticoreGame()
    {
        random = new Random();
        InitializeGame();
    }

    private void InitializeGame()
    {
        manticoreRange = random.Next(0, 100);
        round = 1;
        cityHealth = 15;
        manticoreHealth = 10;
        roundDamage = 1;
        gameOver = false;
    }

    public void RunGame()
    {
        DisplayWelcome();
        
        do
        {
            Console.Clear();
            Console.WriteLine("\nDefend Consolas from the Manticore");
            Console.WriteLine("---------------------------------------------");
            GameStatus();
            
            if (!gameOver)
            {
                CannonRange();
                round++;
                cityHealth--;
            }
        } while (!gameOver);

        AskToPlayAgain();
    }

    private void DisplayWelcome()
    {
        Console.Clear();
        Console.WriteLine("=== Welcome to Manticore Defense ===");
        Console.WriteLine("Protect the city of Consolas from the approaching Manticore!");
        Console.WriteLine("Press any key to begin...");
        Console.ReadKey();
    }

    private void GameStatus()
    {
        string status = $"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {manticoreHealth}/10";
        Console.WriteLine(status);

        if (manticoreHealth <= 0)
        {
            Console.Clear();
            Console.WriteLine("\n🎉 The Manticore has been destroyed! The city of Consolas has been saved! 🎉\n");
            gameOver = true;
            return;
        }

        if (cityHealth <= 0)
        {
            Console.Clear();
            Console.WriteLine("\n💔 The Manticore has defeated Consolas! The city lies in ruins... 💔\n");
            gameOver = true;
            return;
        }

        CalculateRoundDamage();
        Console.WriteLine($"\nThe cannon is expected to deal {roundDamage} damage this round.");
    }

    private void CalculateRoundDamage()
    {
        bool isMultipleOf3 = round % 3 == 0;
        bool isMultipleOf5 = round % 5 == 0;

        if (isMultipleOf3 && isMultipleOf5)
            roundDamage = 10;
        else if (isMultipleOf3 || isMultipleOf5)
            roundDamage = 3;
        else
            roundDamage = 1;
    }

    private void CannonRange()
    {
        while (true)
        {
            Console.Write("Enter your cannon range (0-100): ");
            if (int.TryParse(Console.ReadLine(), out int rangeChoice))
            {
                if (rangeChoice >= 0 && rangeChoice <= 100)
                {
                    ProcessShot(rangeChoice);
                    break;
                }
            }
            Console.WriteLine("Please enter a valid number between 0 and 100.");
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    private void ProcessShot(int rangeChoice)
    {
        if (rangeChoice > manticoreRange)
        {
            Console.WriteLine("That round OVERSHOT the Manticore! 🔼");
        }
        else if (rangeChoice < manticoreRange)
        {
            Console.WriteLine("That round FELL SHORT of the Manticore! 🔽");
        }
        else
        {
            manticoreHealth -= roundDamage;
            Console.WriteLine($"DIRECT HIT! 💥 Dealt {roundDamage} damage!");
        }
    }

    private void AskToPlayAgain()
    {
        Console.WriteLine("Would you like to play again? (Y/N)");
        if (Console.ReadKey().Key == ConsoleKey.Y)
        {
            InitializeGame();
            RunGame();
        }
    }
}

// Main Program
class Program
{
    static void Main()
    {
        var game = new ManticoreGame();
        game.RunGame();
    }
}*/
