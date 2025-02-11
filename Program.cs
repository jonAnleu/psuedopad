// Simula's Soup

(Seasoning seasoning, MainIngredients ingredients, SoupType type) soup = GetSoup();
Console.WriteLine($"{soup.seasoning} {soup.ingredients} {soup.type}");

(Seasoning, MainIngredients, SoupType) GetSoup()
{
  Seasoning seasoning = GetSeasoning();
  MainIngredients ingredients = GetIngredients();
  SoupType type = GetSoupType();
  return (seasoning, ingredients, type);
}

Seasoning GetSeasoning()
{
  Console.Write("Choose a seasoning (salty, spicy, sweet)");
  string input = Console.ReadLine();

  return input switch
  {
    "salty" => Seasoning.Salty,
    "spicy" => Seasoning.Spicy,
    "sweet" => Seasoning.Sweet
  };
}

MainIngredients GetIngredients()
{
  Console.Write("Choose your ingredient (mushroom, chicken, carrot, potato)");
  string input = Console.ReadLine();
  return input switch
  {
    "mushroom" => MainIngredients.Mushroom,
    "chicken" => MainIngredients.Chicken,
    "carrot" => MainIngredients.Carrot,
    "potato" => MainIngredients.Potato
  };
}

SoupType GetSoupType()
{
  Console.Write("Choose your soup type (soup, stew, gumbo)");
  string input = Console.ReadLine();
  return input switch
  {
    "soup" => SoupType.Soup,
    "stew" => SoupType.Stew,
    "gumbo" => SoupType.Gumbo
  };
}

enum SoupType{ Soup, Stew , Gumbo}
enum MainIngredients{Mushroom, Chicken, Carrot, Potato}
enum Seasoning{Salty, Spicy, Sweet}