// The Prototype

int pilotNumber;
int hunterNumber;
bool validHunterNumber = false;

do
{
  Console.Write("Pilot enter a number between 0-100: ");
  pilotNumber = Convert.ToInt32(Console.ReadLine());
  if (pilotNumber < 0 || pilotNumber > 100)
  {
    Console.WriteLine("\nInvalid number choose a number between 0-100\n");
  }else {
    Console.Clear();
  }

} while (pilotNumber < 0 || pilotNumber > 100);

do
{
  Console.Write("Hunter guess the pilots number, choose between 0-100: ");
  hunterNumber = Convert.ToInt32(Console.ReadLine());
  if (hunterNumber > pilotNumber){
    Console.WriteLine("You guess is too high");
  } else if(hunterNumber < pilotNumber){
    Console.WriteLine("Your guess was too low.");
  }else{
    Console.WriteLine("You guessed the number!");
    validHunterNumber = true;
  }
}while (!validHunterNumber);