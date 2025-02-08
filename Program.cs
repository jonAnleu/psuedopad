// Buying Inventory

Console.Write("What number do you want to see the price of? ");
string? response = Console.ReadLine();
response = response switch 
{
  "1" => "Rope: 10",
  "2" => "Torches: 15",
  "3" => "Climbing Equipment: 25",
  "4" => "Clean Water: 1",
  "5" => "Machete: 20",
  "6" => "Canoe: 200",
  "7" => "Food Supplies: 1",
  _ => "Enter a number 1-7"
};
Console.WriteLine(response);